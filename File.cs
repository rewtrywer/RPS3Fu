using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace рпс3
{
    internal class File2
    {
        public static void SaveDataToFile(TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4, TextBox textBox5, DataGridView dataGridView1)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text File|*.txt";
            saveFileDialog1.Title = "Save to Text File";
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(textBox1.Text);
                    writer.WriteLine(textBox2.Text);
                    writer.WriteLine(textBox3.Text);
                    writer.WriteLine(textBox4.Text);
                    writer.WriteLine(textBox5.Text);

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            writer.Write(cell.Value);
                            writer.Write("\t"); // Добавляем разделитель, например, табуляцию
                        }
                        writer.WriteLine(); // Переходим на новую строку после записи строки таблицы
                    }
                }

                MessageBox.Show("Данные из таблички успешно сохранены в файл: " + filePath);
            }
        }

        public static void LoadDataFromFile(TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4, TextBox textBox5)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text File|*.txt";
            openFileDialog1.Title = "Open Text File";
            //bool err=CheckFileData(openFileDialog1.FileName);

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog1.FileName;
                    //bool err = IsValidFileForAddingArray(filePath);

                    //if (err)
                    //{

                        using (StreamReader reader = new StreamReader(filePath))
                        {
                            textBox1.Text = reader.ReadLine()?.Replace("Data 1: ", "");
                            textBox2.Text = reader.ReadLine()?.Replace("Data 2: ", "");
                            textBox3.Text = reader.ReadLine()?.Replace("Data 3: ", "");
                            textBox4.Text = reader.ReadLine()?.Replace("Data 4: ", "");
                            textBox5.Text = reader.ReadLine()?.Replace("Data 5: ", "");
                        }

                        MessageBox.Show("Данные успешно загружены из файла: " + filePath);
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Файл некорректен. Пожалуйста, проверьте его и попробуйте ещё раз.");
                    //}
                }
            
           
        }

        //public static bool IsValidFileForAddingArray(string filePath)
        //{
        //    bool errFlag = true;
        //    int q = 0; 
        //    using (StreamReader formatReader = new StreamReader(filePath))
        //    {
        //        while (q < 5)
        //        {
        //            q += 1;
        //            bool result = double.TryParse(formatReader.ReadLine(), out double temp);
        //            if (result == false)
        //            {

        //                errFlag = false;
        //                return errFlag;
        //            }

        //        }
        //        q = 0;

        //    }
        //    //return true; //?????????????????????????????????????????????????????????????????????????????


        //}

        //public static bool IsValidFileForAddingArray(string filePath)
        //{
        //    bool errFlag = true;
        //    int q = 0;
        //    string tmp1="";
        //    string tmp2="";
        //    using (StreamReader formatReader = new StreamReader(filePath))
        //    {
        //        while (q < 5)
        //        {
        //            q += 1;
        //            string line = formatReader.ReadLine();
                    
                    
        //            if (q == 3)
        //            {
        //                if (!double.TryParse(line, out double temp) || temp < 0)
        //                {
        //                    errFlag = false;
        //                    return errFlag;
        //                }
        //            }
        //            else
        //            {
        //                if (!double.TryParse(line, out _))
        //                {
        //                    errFlag = false;
        //                    return errFlag;
        //                }
        //            }
        //            if (q == 4)
        //            {
        //                tmp1 = line;
        //            }
        //            if (q == 5)
        //            {
        //                tmp2 = line;
        //            }
        //            if (double.TryParse(tmp1, out _) && double.TryParse(tmp2, out _) && tmp1 >= tmp2)
        //            {

        //            }
        //            if (q == 5 && errFlag) // Add this condition to return true if all checks passed
        //            {
        //                return true;
        //            }
        //        }
        //    }
        //    return errFlag; // Return errFlag if the loop exits early
        //}
    }
}
