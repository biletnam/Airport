using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev
{
    public partial class Frm : Form
    {
        static int NumReis = 1;                                       // Счётчик нумерации рейсов.

        List<string> numbers = new List<string> { };
        public Frm()
        {
            InitializeComponent();
        }

        private void Frm_Load(object sender, EventArgs e)
        {
            Adrs.ForeColor = Color.Gray;
            Adrs.Text = "SPB";
            FIO.ForeColor = Color.Gray;
            FIO.Text = "Иванов Павел Олегович";
            dateTime.ForeColor = Color.Gray;
            dateTime.Text = "19:45";
            dateDay.ForeColor = Color.Gray;
            dateDay.Text = "18/01/16";
            txtNumR.ForeColor = Color.Gray;
            txtNumR.Text = "1";
            txtDateR.ForeColor = Color.Gray;
            txtDateR.Text = "18/01/16";
            obman.Select();
        }          // Образец заполнения данных в полях.

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nomerReisa = null;                                 // Переменная для поиска рейса в массиве.
            string adres = Adrs.Text.Trim();                          // Переменная хранения пункта назначения.
            string[] fio = FIO.Text.Replace("  ", " ").Split();       // Массив ФИО.
            string time = dateTime.Text.Trim();                       // Переменная для хранения времени рейса.
            string day = dateDay.Text.Trim();                         // Переменная для хранения даты рейса.
            bool cont = true;
            try
            {
                string temp = "";                                     // Переменная для сохранения заявки.
                if (adres.Length > 7)                                 // Вывод заявки в ListBox.
                {
                    if ((fio[0] + fio[1] + fio[2]).Length > 20 && (fio[0] + fio[1] + fio[2]).Length < 26)
                        temp = "\t      " + adres + " \t" + fio[0] + "  " + fio[1] + "  " + fio[2] + "\t\t" + time + "  " + day;
                    else temp = "\t    " + adres + " \t\t" + fio[0] + "  " + fio[1] + "  " + fio[2] + "\t\t\t" + time + "  " + day;
                }
                else
                {
                    if ((fio[0] + fio[1] + fio[2]).Length > 20 && (fio[0] + fio[1] + fio[2]).Length < 26)
                        temp = "\t      " + adres + " \t\t\t" + fio[0] + "  " + fio[1] + "  " + fio[2] + "\t\t" + time + "  " + day;
                    else temp = "\t      " + adres + " \t\t\t" + fio[0] + "  " + fio[1] + "  " + fio[2] + "\t\t\t" + time + "  " + day;
                }

                for (int i = 0; i < numbers.Count; i++)               // Проверка наличия заявки в массиве.
                {
                    string temps = adres + fio[0].Trim() + fio[1].Trim() + fio[2].Trim() + time + day;
                    if (numbers[i] == (int)(NumReis - 1) + temps)
                    {
                        cont = false;
                    }
                }
                if (cont)                                             // Добавления заявки, если такой ещё не было.
                {
                    if ((Adrs.Text + FIO.Text + dateTime.Text + dateDay.Text) != "SPBИванов Павел Олегович19:4518/01/16")
                    {
                        bool log = false;
                        NumReis++;                                    // Увеличение счётчика рейса.   
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            nomerReisa = "";
                            for (int j = 0; j < numbers.Count; j++)
                            {
                                if ((numbers[i][j] > '0') && (numbers[i][j] <= '9')) nomerReisa += numbers[i][j]; // Составление номера рейса.
                                else break;
                            }
                            if (numbers[i].Contains(adres) && numbers[i].Contains(time + day))                    // Добавление записи с готовым рейсом.
                            {
                                numbers.Add(int.Parse(nomerReisa) + adres + fio[0].Trim() + fio[1].Trim() + fio[2].Trim() + time + day); lstSp.Items.Add(int.Parse(nomerReisa) + temp); log = true; NumReis--; break;
                            }
                        }
                        if (log == false)
                        {
                            numbers.Add((NumReis - 1) + adres + fio[0].Trim() + fio[1].Trim() + fio[2].Trim() + time + day); // Добавление записи с новым рейсом.
                            lstSp.Items.Add((NumReis - 1) + temp);                                                           // Вывод нового рейса.
                        }



                    }
                    else MessageBox.Show(" Введите другие данные ", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show(" Введите другие данные ", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch { MessageBox.Show(" Проверьте правильность данных ", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error); };

        }      //Добавление записи.

        private void Adrs_Enter(object sender, EventArgs e)
        {
            byte k = 0;
            if (k == 0)
            {
                Adrs.Text = null;
                Adrs.ForeColor = Color.Black;
            }
            k++;
        }        // Изменения текста в случае пустого поля.
        private void Adrs_Leave(object sender, EventArgs e)
        {

            if (Adrs.Text == "") { Adrs.ForeColor = Color.Gray; Adrs.Text = "SPB"; }

        }        // Изменения текста в случае пустого поля.
        private void FIO_Enter(object sender, EventArgs e)
        {
            byte k = 0;
            if (k == 0)
            {
                FIO.Text = null;
                FIO.ForeColor = Color.Black;
            }
            k++;
        }         // Изменения текста в случае пустого поля.
        private void FIO_Leave(object sender, EventArgs e)
        {
            if (FIO.Text == "") { FIO.ForeColor = Color.Gray; FIO.Text = "Иванов Павел Олегович"; }
        }         // Изменения текста в случае пустого поля.
        private void dateTime_Enter(object sender, EventArgs e)
        {
            byte k = 0;
            if (k == 0)
            {
                dateTime.Text = null;
                dateTime.ForeColor = Color.Black;
            }
            k++;
        }    // Изменения текста в случае пустого поля.
        private void dateTime_Leave(object sender, EventArgs e)
        {
            if (dateTime.Text == "") { dateTime.ForeColor = Color.Gray; dateTime.Text = "19:45"; }
        }    // Изменения текста в случае пустого поля.
        private void dateDay_Enter(object sender, EventArgs e)
        {
            byte k = 0;
            if (k == 0)
            {
                dateDay.Text = null;
                dateDay.ForeColor = Color.Black;
            }
        }     // Изменения текста в случае пустого поля.
        private void dateDay_Leave(object sender, EventArgs e)
        {
            if (dateDay.Text == "") { dateDay.ForeColor = Color.Gray; dateDay.Text = "18/01/16"; }
        }     // Изменения текста в случае пустого поля.
        private void txtNumR_Enter(object sender, EventArgs e)
        {
            byte k = 0;
            if (k == 0)
            {
                txtNumR.Text = null;
                txtNumR.ForeColor = Color.Black;
            }
            k++;
        }     // Изменения текста в случае пустого поля.
        private void txtDateR_Enter(object sender, EventArgs e)
        {
            byte k = 0;
            if (k == 0)
            {
                txtDateR.Text = null;
                txtDateR.ForeColor = Color.Black;
            }
            k++;
        }    // Изменения текста в случае пустого поля.
        private void txtNumR_Leave(object sender, EventArgs e)
        {
            if (txtNumR.Text == "") { txtNumR.ForeColor = Color.Gray; txtNumR.Text = "1"; }
        }     // Изменения текста в случае пустого поля.
        private void txtDateR_Leave(object sender, EventArgs e)
        {
            if (txtDateR.Text == "") { txtDateR.ForeColor = Color.Gray; txtDateR.Text = "18/01/16"; }
        }    // Изменения текста в случае пустого поля.
        private void brnDel_Click(object sender, EventArgs e)
        {
            if (lstSp.SelectedIndex != -1)
            {
                numbers.RemoveAt(lstSp.SelectedIndex);
                lstSp.Items.RemoveAt(lstSp.SelectedIndex);
            }
            else MessageBox.Show(" Выделите заявку ", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }      // Удалить выделенную заявку.

        private void btnFind1_Click(object sender, EventArgs e)
        {
            lstFind.Items.Clear();
            bool fn = false;
            string tempReis="";
            if (lstSp.Items.Count == 0) MessageBox.Show("Заявок нет!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error); // Проверка на наличие заявок.
            else
            try
            {
                int nm = int.Parse(txtNumR.Text.Trim());
                for(int i=0;i<lstSp.Items.Count;i++)
                {
                    tempReis = "";
                    for (int j = 0; j < lstSp.Items.Count; j++)
                    {
                        string t = lstSp.Items[i].ToString();                // Переменная, которая хранит в себе запис.
                        if ((t[j] > '0') && (t[j] <= '9')) tempReis += t[j]; // Составление номера рейса из записи.
                        else break;
                    }
                    if (int.Parse(tempReis) == nm)
                    {                        
                        lstFind.Items.Insert(0, lstSp.Items[i]); // Добавление в список найденой записи.
                        fn = true;
                    }
                   
                }
                if (!fn) MessageBox.Show("Не найдено.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error); // В случае отсутствия заявки.
                    
            }
            catch { MessageBox.Show(" Проверьте правильность данных ", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }    // Найти заявку по номеру рейса.

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstFind.Items.Clear();
        }    // Очистить список заявок.

        private void btnFind2_Click(object sender, EventArgs e)
        {
            lstFind.Items.Clear();
            bool lg = false;
            string dr=txtDateR.Text.Trim();
            for (int i = 0; i < lstSp.Items.Count; i++)
            {
                for (int j=0;j<lstSp.Items[i].ToString().Length-dr.Length;j++)
                {
                    if (lstSp.Items[i].ToString().Substring(dr.Length + j) == dr) { lg = true; lstFind.Items.Add(lstSp.Items[i]); }
                }               
            }
            if (!lg) MessageBox.Show("Не найдено.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error); // В случае отсутствия заявки.
        }    // Поиск заявки по дате рейса.
    }

}
