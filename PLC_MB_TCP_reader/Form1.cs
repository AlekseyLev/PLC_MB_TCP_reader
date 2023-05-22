using EasyModbus;
using System.Diagnostics;
using System.Drawing;
using System.Text.RegularExpressions;
using static System.Windows.Forms.AxHost;
//using System.Windows.Forms;
//using static System.Net.Mime.MediaTypeNames;
//using static System.Windows.Forms.AxHost;


namespace xxx_degazator
{
    public partial class Form1 : Form
    {
        ModbusClient plc; // во как! Прям тут инициализация
        string patternIP = @"^(\d{1,3})\.(\d{1,3})\.(\d{1,3})\.(\d{1,3})$";
        string patternPort = @"^\d{1,5}$"; // Порт представляет 2-х байтное значение от 0 до 65535
        string patternSec = @"^\d{1,2}$";
        bool bConnect = false;
        int progressbar = 0;              

        // назначаю адреса битов Мх.х из ПЛК для чтения и записи. Расчёт адреса делаю в Экселе,
        // хотя можно сделать здесь свою dll		
        string GV_di_check_1 = "1408", // биты КМ1
               GV_di_sk_1 = "1409",

               GV_di_check_2 = "1416", // биты КМ2

               GV_di_check_3 = "1424", // биты КМ3
               GV_di_sl1_3 = "1425",
               GV_di_press2_3 = "1426",

               GV_di_check_4 = "1432", // биты К4
               GV_di_slh_4 = "1433";

        string GV_app_iTimer_K4 = "166"; // уставка КМ1-К4 в секундах (10, по умолчанию, было)
        int GV_bREC_app = 1398; // адрес бита, который скажет ПЛК, что ведётся перезапись. Обнуляется в ПЛК
                                // адреса битов системных сообщений
        int GV_bit_faultA = 1392;
        // GV_bit_faultP = 1393,
        // GV_bit_Ready = 1394,
        // GV_bit_Manu = 1395,
        // GV_bit_Auto = 1396; // не нужны. Я их запрашиваю в кол-ве 5 битов, используя первый бит

        int timeAutoSet = 10; // уставка выдержки времени по умолчанию в Авторежиме (сек). При записи х10 надо делать

        //Объявление массивов для записи выше указанных bool битов
        bool[] bools_KM1;
        bool[] bools_KM2;
        bool[] bools_KM3;
        bool[] bools_K4;

        bool[] bools_all = new bool[8]; // все КМ1-КМ3,К4 в один массив
        bool[] bools_msj = new bool[5]; // все сообщений от битов 1392..1396


        int c1, c2, c3, c4;            // значения счётчиков в int и str форматах
        string str1, str2, str3, str4;

#nullable disable
        public Form1()
        {
            InitializeComponent();

            AutoCompleteStringCollection source = new()
        {
            "192.168.8.79",
            "192.168.1.163"
        };
            textBoxIP.AutoCompleteCustomSource = source;

            timer1.Interval = 3000; // мсек - МОЖЕМ МЕНЯТЬ

            timerForProgressBar.Interval = timer1.Interval / 10; // не нужно уже менять, всё высчитано
            progressBar1.Step = timerForProgressBar.Interval;
            progressBar1.Maximum = timer1.Interval;


            //Запись DWORD/DINT в библиотеке EasyModbus методом тыка ведётся массивом 2-ух чисел в формате (далее показываю в формате intА _ intВ):

            //0 - 65535 = число этого диапазона _ 0
            //65536 - 131070 = число этого диапазона _ 1
            //131071 - 196607 = число этого диапазона _ 2
            //196608 - 262143 =  число этого диапазона _ 3 (первое число - это: 65536*3-1, а второе 65536*4-1
            // и так далее, видимо, до 2,... млн

            //c1 = c2 = c3 = c4 = -333;

        }

        public string IntToHEXstr(int val) => Convert.ToString(val, 16);
        public void ReadPLC()
        {
            if (bConnect)
            {
                c1 = ModbusClient.ConvertRegistersToInt(plc.ReadHoldingRegisters(150, 2));
                c2 = ModbusClient.ConvertRegistersToInt(plc.ReadHoldingRegisters(154, 2));
                c3 = ModbusClient.ConvertRegistersToInt(plc.ReadHoldingRegisters(158, 2));
                c4 = ModbusClient.ConvertRegistersToInt(plc.ReadHoldingRegisters(162, 2));

                str1 = c1.ToString();
                str2 = c2.ToString();
                str3 = c3.ToString();
                str4 = c4.ToString();

                //Определим максимальную длину строки счётчика:
                int len = c1.ToString().Length;
                string[] strValues = { c1.ToString(), c2.ToString(), c3.ToString(), c4.ToString() };

                for (int i = 1; i < strValues.Length; i++)
                {
                    if (len < strValues[i].Length) len = strValues[i].Length;
                }

                //И зададим длину выходного числа:
                string format = $"{{0:d{len}}}";

                count1.Text = string.Format(format, c1) + " мин.";
                count2.Text = string.Format(format, c2) + " мин.";
                count3.Text = string.Format(format, c3) + " мин.";
                count4.Text = string.Format(format, c4) + " мин.";

                hexCodirovka.Text = $"{IntToHEXstr(c1)}:{IntToHEXstr(c2)}:{IntToHEXstr(c3)}:{IntToHEXstr(c4)}";

                ReadBools(); //читаем биты                    
                SetBackColor_Bools(); // ставим жёлтый, если бит не активен
                ReadMsj(); //читаем сообщения



            }
            else
            {
                count1.Text = count2.Text = count3.Text = count4.Text = "-----";
                timer1.Stop();
                timerForProgressBar.Stop();
                progressBar1.Value = 0;
                EnableSettings(false);
            }
        }

        public void ReadTimeSet()
        {
            int msec = ModbusClient.ConvertRegistersToInt(plc.ReadHoldingRegisters(Convert.ToInt32(GV_app_iTimer_K4), 2));
            var sec = msec / 10; // такой коэффициент у Kinco...
            textBox_SetSeconds.Text = sec.ToString();
        }
        //читаем состояние битов
        public void ReadBools()
        {
            bools_KM1 = plc.ReadDiscreteInputs(int.Parse(GV_di_check_1), 2);
            bools_KM2 = plc.ReadDiscreteInputs(int.Parse(GV_di_check_2), 1);
            bools_KM3 = plc.ReadDiscreteInputs(int.Parse(GV_di_check_3), 3);
            bools_K4 = plc.ReadDiscreteInputs(int.Parse(GV_di_check_4), 2);

            //инверсия битов. То, что на экране True, на самом деле False
            bools_all[0] = !bools_KM1[0];
            bools_all[1] = !bools_KM1[1];
            bools_all[2] = !bools_KM2[0];
            bools_all[3] = !bools_KM3[0];
            bools_all[4] = !bools_KM3[1];
            bools_all[5] = !bools_KM3[2];
            bools_all[6] = !bools_K4[0];
            bools_all[7] = !bools_K4[1];

        }

        public void ReadMsj()
        {
            string sysMsj = "";
            bool bit_faultA = false, //1392
                bit_faultP = false, //1393
                bit_Ready = false, //1394
                bit_Manu = false, //1395
                bit_Auto = false, //1396
                bit_Check = false; // 1397

            bools_msj = plc.ReadDiscreteInputs(GV_bit_faultA, 6);
            bit_faultA = bools_msj[0];
            bit_faultP = bools_msj[1];
            bit_Ready = bools_msj[2];
            bit_Manu = bools_msj[3];
            bit_Auto = bools_msj[4];
            bit_Check = bools_msj[5];

            if (bit_faultA) sysMsj += "Авария. Причина аварии активна\n";
            if (bit_faultP) sysMsj += "Авария. Причина аварии не активна.\nПереведите ключ SA10 в положение \"0\" для сброса.\n";
            if (bit_Ready) sysMsj += "Готов к работе.\n";
            if (bit_Manu) sysMsj += "Установка работает в Ручном режиме.\n";
            if (bit_Auto) sysMsj += "Установка работает в Авто режиме.\n";
            if (bit_Check) sysMsj += "Проверьте состояние автоматов и тепловых реле в шкафу\n";


            if (sysMsj == "") sysMsj = "Ошибка чтения системных сообщений";
            lbl_SysMsj.Text = sysMsj;
        }

        public void SetCheckBools()
        {
            di_check_1.Checked = !bools_KM1[0];
            di_sk_1.Checked = !bools_KM1[1];
            di_check_2.Checked = !bools_KM2[0];
            di_check_3.Checked = !bools_KM3[0];
            di_sl1_3.Checked = !bools_KM3[1];
            di_press2_3.Checked = !bools_KM3[2];
            di_check_4.Checked = !bools_K4[0];
            di_slh_4.Checked = !bools_K4[1];
        }

        public void SetBackColor_Bools()
        {
            string[] color = new string[8];
            for (int i = 0; i < bools_all.Length; i++)
            {
                if (bools_all[i]) color[i] = "WhiteSmoke";
                else color[i] = "Yellow";
            }

            di_check_1.BackColor = System.Drawing.Color.FromName(color[0]);
            di_sk_1.BackColor = System.Drawing.Color.FromName(color[1]);
            di_check_2.BackColor = System.Drawing.Color.FromName(color[2]);
            di_check_3.BackColor = System.Drawing.Color.FromName(color[3]);
            di_sl1_3.BackColor = System.Drawing.Color.FromName(color[4]);
            di_press2_3.BackColor = System.Drawing.Color.FromName(color[5]);
            di_check_4.BackColor = System.Drawing.Color.FromName(color[6]);
            di_slh_4.BackColor = System.Drawing.Color.FromName(color[7]);

        }

        // Активация и деактивация чекбоксов сигналов управления
        public void ChangeBox_Enabled(bool state)
        {
            //убрал отсюда Enable настроек в метод EnableSettings()

            // и добавим сюда ещё кое-какие элементы...

            label_Read.Enabled = state;
            progressBar1.Enabled = state;
            textBoxIP.Enabled = textBoxPort.Enabled = !state;
            lbl_SysMsj.Enabled = state;
        }

        public void EnableSettings(bool state)
        {
            di_check_1.Enabled =
            di_sk_1.Enabled =
            di_check_2.Enabled =
            di_check_3.Enabled =
            di_sl1_3.Enabled =
            di_press2_3.Enabled =
            di_check_4.Enabled =
            di_slh_4.Enabled =
            textBox_SetSeconds.Enabled =
            btn_Change.Enabled =
            btn_Defolt.Enabled = state;

            if (state) pictureBox_Lock.Visible = false;
            else pictureBox_Lock.Visible = true;
        }


        private void butConnect_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Cоединяю...");
            plc = new ModbusClient();
            bool bitIP = false, bitPort = false;
            if (Regex.IsMatch(textBoxIP.Text, patternIP)) bitIP = true;
            else textBoxIP.BackColor = System.Drawing.Color.LightCoral;

            if (Regex.IsMatch(textBoxPort.Text, patternPort)) bitPort = true;
            else textBoxPort.BackColor = System.Drawing.Color.LightCoral;
            bool bitOn = false;

            if (bitIP && bitPort)
            {
                plc.IPAddress = textBoxIP.Text;
                plc.Port = Convert.ToInt32(textBoxPort.Text);
                try
                {
                    plc.Connect();
                    bConnect = true;
                    lblStatus.Text = "Connected";
                    lblStatus.BackColor = System.Drawing.Color.LimeGreen;

                    textBoxIP.BackColor = textBoxPort.BackColor = System.Drawing.Color.WhiteSmoke;
                    btnConnect.Enabled = false;
                    btnDisconnect.Enabled = true;
                    bitOn = true;
                    //progressBar1.Visible = true;
                }
                catch
                {
                    lblStatus.Text = "Not successful";
                    lblStatus.BackColor = System.Drawing.Color.LightCoral;
                    MessageBox.Show("Если IP и Port введены верно, проверьте:\n" +
                        "- целостность физического соединения;\n" +
                        "- настройки сетевого адаптера на вашем устройстве", "ОШИБКА СОЕДИНЕНИЯ!");
                }

                if (bitOn) // если смогли подключиться, пробуем читать ПЛК
                {
                    try // вряд ли этот блок нужен, но оставил с момента отладки, т.к. делал ошибку тут
                    {
                        ReadPLC();
                        ReadTimeSet();

                        SetCheckBools();
                        ChangeBox_Enabled(true);

                        timer1.Start();
                        timerForProgressBar.Start();
                    }
                    catch
                    {
                        MessageBox.Show("Соединение выполнено, но произошла ошибка чтения состояний ПЛК.\n\n" +
                        "Убедитесь, что версия программы соответствует версии прошивки ПЛК");
                    }
                }
            }


            //textBoxIP.BackColor = textBoxPort.BackColor = this.BackColor; // Form1 I mean


        }



        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        public void Disconnect()
        {
            plc.Disconnect();
            bConnect = false;
            lblStatus.Text = "Disconnected";
            lbl_SysMsj.Text = "Нет подключения";
            lblStatus.BackColor = System.Drawing.Color.Yellow;

            btnDisconnect.Enabled = false;
            btnConnect.Enabled = true;

            ChangeBox_Enabled(false);
            ReadPLC();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = "https://metanit.com/sharp/windowsforms/", UseShellExecute = true });
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_Lock_Click(object sender, EventArgs e)
        {
            if (bConnect)
            {
                DialogResult result = MessageBox.Show(
                    "Нажимая \"ОК\", вы понимаете, что изменение настроек может привести к выходу из строя оборудования и быть причиной отказа производителя от гарантийных обязательств",
                    "Разблокировать настройки",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information
                    //MessageBoxDefaultButton.Button1,
                    //MessageBoxOptions.DefaultDesktopOnly
                    );

                if (result == DialogResult.OK)
                {
                    EnableSettings(true);

                }
            }
            else MessageBox.Show("Используйте эту кнопку для разблокировки настроек после подключения к ПЛК",
                "Cправка");
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("По условиям Авторежима перед включением клапана на впуск масла включаются ТЭНы на разогрев.\n\n" +
                $"По умолчанию уставка = {timeAutoSet} сек. Принимается значение 0-30 сек.\n",
                "Справка");
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            bool check = false;
            string msj;

            if (Regex.IsMatch(textBox_SetSeconds.Text, patternSec))
            {
                if (Convert.ToInt32(textBox_SetSeconds.Text) < 31) check = true;
            }

            if (check)
            {
                textBox_SetSeconds.BackColor = System.Drawing.Color.White;
                // запишем уставку секунд с коэфициентом х10 (так надо контроллеру)
                plc.WriteSingleRegister(int.Parse(GV_app_iTimer_K4), 10 * int.Parse(textBox_SetSeconds.Text));
                plc.WriteSingleCoil(GV_bREC_app, true);
                // записываем биты. На экране они true, но по факту мы их отключаем
                // потому что в прошивке ПЛК эти биты "н.о." по умолчанию. Если мы их "трогаем" этой программой, то делаем "н.з."
                plc.WriteSingleCoil(int.Parse(GV_di_check_1), !di_check_1.Checked);
                plc.WriteSingleCoil(int.Parse(GV_di_sk_1), !di_sk_1.Checked);
                plc.WriteSingleCoil(int.Parse(GV_di_check_2), !di_check_2.Checked);
                plc.WriteSingleCoil(int.Parse(GV_di_check_3), !di_check_3.Checked);
                plc.WriteSingleCoil(int.Parse(GV_di_sl1_3), !di_sl1_3.Checked);
                plc.WriteSingleCoil(int.Parse(GV_di_press2_3), !di_press2_3.Checked);
                plc.WriteSingleCoil(int.Parse(GV_di_check_4), !di_check_4.Checked);
                plc.WriteSingleCoil(int.Parse(GV_di_slh_4), !di_slh_4.Checked);

                if (bConnect) msj = "Настройки изменены";
                else msj = "Возможно, произошла ошибка записи! Выполните переподключение к ПЛК и повторите попытку";
            }
            else
            {
                textBox_SetSeconds.BackColor = System.Drawing.Color.LightCoral;
                msj = "Уставка времени не входит в диапазон целых чисел 0-30 сек.\nИзменения не приняты";
            }
            MessageBox.Show(msj);

        }

        private void btn_Defolt_Click(object sender, EventArgs e)
        {
            // запишем 10 сек с коэфициентом х10 (так надо контроллеру)
            plc.WriteSingleRegister(int.Parse(GV_app_iTimer_K4), 10 * timeAutoSet);
            // записываем биты
            plc.WriteSingleCoil(int.Parse(GV_di_check_1), false);
            plc.WriteSingleCoil(int.Parse(GV_di_sk_1), false);
            plc.WriteSingleCoil(int.Parse(GV_di_check_2), false);
            plc.WriteSingleCoil(int.Parse(GV_di_check_3), false);
            plc.WriteSingleCoil(int.Parse(GV_di_sl1_3), false);
            plc.WriteSingleCoil(int.Parse(GV_di_press2_3), false);
            plc.WriteSingleCoil(int.Parse(GV_di_check_4), false);
            plc.WriteSingleCoil(int.Parse(GV_di_slh_4), false);

            MessageBox.Show("Установлены значения по умолчанию");
            textBox_SetSeconds.BackColor = System.Drawing.Color.White;

            di_check_1.Checked =
            di_sk_1.Checked =
            di_check_2.Checked =
            di_check_3.Checked =
            di_sl1_3.Checked =
            di_press2_3.Checked =
            di_check_4.Checked =
            di_slh_4.Checked = true;
        }

        private void timerForProgressBar_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            if (!bConnect || progressbar == progressBar1.Maximum) progressBar1.Value = 0;
            progressbar = progressBar1.Value;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выделенные сигналы контролируют включение силовых элементов установки в Ручном режиме.\n\n" +
                "При необходимости измените перечень контрольных сигналов и нажмите \"Изменить\".\n" +
                "Для возвращения к стандартным настройкам нажмите кнопку \"По умолчанию\"\n\n" +
                "В случае деактивации сигнал выделяется жёлтым цветом как не соответствующий настройкам по умолчанию.",
                "Справка");
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Производитель: ООО \"Автотрансформатор\"\n" +
            //             "Телефон: 8-800-200-63-18\n" +
            //             @"Веб-сайт: https://avtotransformator.ru/");
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                ReadPLC();
            }
            catch
            {
                Disconnect();
                MessageBox.Show("Связь потеряна");
            }
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void count1_Click(object sender, EventArgs e)
        {
            //while (bConnect)
            //{
            //    c1 = ModbusClient.ConvertRegistersToInt(plc.ReadHoldingRegisters(150, 2));
            //    count1.Text = c1.ToString();
            //}
            //if (!bConnect) count1.Text = "-----";
        }
    }
}