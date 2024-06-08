using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entities.Models;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinUI1
{
    public partial class Anket : Form
    {
        private IFirebaseClient client;
        private List<survey> sorular;
        private int currentQuestionIndex = 0;
        private int currentQuestionCount = 1;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "6Z0KM9sVW6mj8zOqeOLgS1FtJy9jRamR81JUEYKc",
            BasePath = "https://humanresourcemanagmentsy-588b9-default-rtdb.europe-west1.firebasedatabase.app/",
        };

        static bool connectionCheck()
        {
            try
            {
                return new System.Net.NetworkInformation.Ping().Send("www.google.com", 1000).Status == System.Net.NetworkInformation.IPStatus.Success;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void connectionCheck_Load()
        {
            if (connectionCheck() == false)
            {
                MessageBox.Show("İnternet Bağlantınızı Kontrol Ediniz!");
                this.Close();
            }
            else
            {
                client = new FireSharp.FirebaseClient(config);
                if (client == null)
                {
                    MessageBox.Show("Firebase bağlantısı kurulamadı!");
                }
            }
        }

        public Anket()
        {
            InitializeComponent();
            connectionCheck_Load();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            sorular = new List<survey>();
        }

        private void Anket_Load(object sender, EventArgs e)
        {
            try
            {
                FirebaseResponse sorularSnapshot = client.Get("survey/");
                if (sorularSnapshot.Body != "null")
                {
                    Dictionary<string, survey> result = sorularSnapshot.ResultAs<Dictionary<string, survey>>();

                    foreach (var get in result)
                    {
                        sorular.Add(get.Value);
                    }

                    DisplayQuestion();
                }
                else
                {
                    MessageBox.Show("Survey verisi bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Firebase'den veriler alınırken bir hata oluştu: " + ex.Message);
            }
        }

        private void DisplayQuestion()
        {
            ResetRadioButtons();
            if (currentQuestionIndex < sorular.Count)
            {
                survey currentQuestion = sorular[currentQuestionIndex];
                groupBox1.Text ="Soru " + currentQuestionCount.ToString();
                label1.Text = currentQuestion.soru;
                radioButton1.Text = currentQuestion.a;
                radioButton2.Text = currentQuestion.b;
                radioButton3.Text = currentQuestion.c;
                radioButton4.Text = currentQuestion.d;
            }
            else
            {
                MessageBox.Show("Tebrikler! Soruları tamamladınız.");
                Form1 form = new Form1(); // ana sayfa olarak değişecek
                form.Show();
                this.Hide();
            }
        }

        private void ResetRadioButtons()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedAnswer = GetSelectedAnswer();
                if (string.IsNullOrEmpty(selectedAnswer))
                {
                    MessageBox.Show("Lütfen bir şık seçin.");
                    return;
                }

                // Her soru için benzersiz bir kimlik varsayıyoruz, örneğin questionId
                string questionId = sorular[currentQuestionIndex].id;

                // Firebase'den mevcut sayıları al
                var response = client.Get("questionAnswer/" + questionId);
                questionAnswer qa;
                if (response.Body == "null")
                {
                    qa = new questionAnswer { questionId = questionId };
                }
                else
                {
                    qa = response.ResultAs<questionAnswer>();
                }

                // Güncellemeden önceki sayıları logla
                MessageBox.Show($"Güncelleme Öncesi -{qa.questionId} - A: {qa.aCount}, B: {qa.bCount}, C: {qa.cCount}, D: {qa.dCount}");

                // Seçilen yanıta göre sayıyı güncelle
                switch (selectedAnswer)
                {
                    case "A":
                        qa.aCount++;
                        break;
                    case "B":
                        qa.bCount++;
                        break;
                    case "C":
                        qa.cCount++;
                        break;
                    case "D":
                        qa.dCount++;
                        break;
                }

                // Güncellemeden sonraki sayıları logla
                MessageBox.Show($"Güncelleme Sonrası -{qa.questionId}  A: {qa.aCount}, B: {qa.bCount}, C: {qa.cCount}, D: {qa.dCount}");

                // Firebase'i yeni sayılarla güncelle
                response = client.Set("questionAnswer/" + questionId, qa);

                // Sonraki soruya geç
                currentQuestionIndex++;
                currentQuestionCount++;
                DisplayQuestion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private string GetSelectedAnswer()
        {
            if (radioButton1.Checked)
                return "A";
            else if (radioButton2.Checked)
                return "B";
            else if (radioButton3.Checked)
                return "C";
            else if (radioButton4.Checked)
                return "D";
            else
                return null;
        }
    }
}