using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Game : Form
    {
        static string[] words;

        static string current_word;

        static string show_text;

        static int count_success;

        static int count_spaces;

        static int lives;

        static PictureBox[] lives_image;
       
        static void start_game(RichTextBox wordArea)

        {

            Random random = new Random();
            current_word = words[random.Next(0, words.Length)];
            wordArea.Text = get_show_text(current_word);

        }

        static string get_show_text(string word)

        {

            string result_string = "";

            for (int i = 0; i < word.Length; i++)

            {

                if (word[i]==' ')
                {
                    result_string += " ";
                }
                else
                {
                    result_string += "@";
                }
                    

            }

            return result_string;

        }

        static void centering_text(RichTextBox word_area)

        {
            word_area.SelectAll();
            word_area.SelectionAlignment = HorizontalAlignment.Center;


        }

        static bool is_contains(string word, char symbol)

        {

            for (int i = 0; i < word.Length; i++)

            {

                if (word[i] == symbol)

                {

                    return true;

                }

            }

            return false;

        }

        static string get_new_show_text(string word, char symbol, string old_show_text)

        {

            for (int i = 0; i < word.Length; i++)

            {

                if (word[i] == symbol)

                {

                    old_show_text = old_show_text.Remove(i, 1);

                    old_show_text = old_show_text.Insert(i, symbol.ToString());

                }

            }

            return old_show_text;

        }

        static void button_symbol_click(RichTextBox wordArea, char symbol, Button cur_button, Button startButton)

        {
            if (is_contains(current_word, symbol))

            {

                wordArea.Text = get_new_show_text(current_word, symbol, wordArea.Text);

                if (is_contains(wordArea.Text, '@'))
                {
                    return;
                }

                else
                {
                    using (SuccessForm Success_Form = new SuccessForm()) 

                    {

                        Success_Form.ShowDialog();

                    }
                }
                    

            }

            else

            {

                lives--;
                lives_image[lives].Visible = false;

                if(lives > 0)
                {
                    return;
                }

                else
                {
                    using (Losform los_Form = new Losform())
                    {
                        los_Form.ShowDialog();
                    }
                }
            }

        }

        public Game()

        {

            InitializeComponent();

            lives_image = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 };

            words = new string[] {"лёд", "праздник", "новый год", "лось", "карнавал", "ёлочка", "праздник", "дед мороз", "олень", "сюрприз", "зима", "снегурочка", "ёхансон", "снег", "сугроб" };

            current_word = "";

            show_text = "";

            count_success = 0;

            count_spaces = 0;

            lives = lives_image.Length;

            //pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;

            start_game(RichTextBox1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            button_symbol_click(RichTextBox1, 'а', button1, button34);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            button_symbol_click(RichTextBox1,'б',button4, button34);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            button_symbol_click(RichTextBox1, 'в', button2, button34);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            button_symbol_click(RichTextBox1, 'г', button3, button34);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            button_symbol_click(RichTextBox1, 'д', button5, button34);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            button_symbol_click(RichTextBox1, 'е', button6, button34);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            button_symbol_click(RichTextBox1, 'ё', button7, button34);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            button_symbol_click(RichTextBox1, 'ж', button8, button34);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            button_symbol_click(RichTextBox1, 'з', button9, button34);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            button_symbol_click(RichTextBox1, 'и', button10, button34);
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            button_symbol_click(RichTextBox1, 'й', button11, button34);
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            button_symbol_click(RichTextBox1,'к', button12, button34);
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            button_symbol_click(RichTextBox1,'л', button13, button34);
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            button_symbol_click(RichTextBox1, 'м', button14, button34);
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            button_symbol_click(RichTextBox1,'н', button15, button34);
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            button_symbol_click(RichTextBox1, 'о', button16, button34);
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            button_symbol_click(RichTextBox1, 'п', button17, button34);
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            button_symbol_click(RichTextBox1, 'р', button18, button34);
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            button_symbol_click(RichTextBox1, 'с', button19, button34);
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            button_symbol_click(RichTextBox1, 'т', button20, button34);
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            button_symbol_click(RichTextBox1, 'у', button21, button34);
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            button_symbol_click(RichTextBox1, 'ф', button22, button34);
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            button_symbol_click(RichTextBox1, 'х', button23, button34);
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            button_symbol_click(RichTextBox1, 'ц', button24, button34);
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            button_symbol_click(RichTextBox1, 'ш', button25, button34);
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            button_symbol_click(RichTextBox1,'щ', button26, button34);
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            button_symbol_click(RichTextBox1, 'ъ', button27, button34);
        }

        private void Button28_Click(object sender, EventArgs e)
        {
            button_symbol_click(RichTextBox1, 'ы', button28, button34);
        }

        private void Button29_Click(object sender, EventArgs e)
        {
            button_symbol_click(RichTextBox1, 'ь', button29, button34);
        }

        private void Button30_Click(object sender, EventArgs e)
        {
            button_symbol_click(RichTextBox1, 'э', button30, button34);
        }

        private void Button31_Click(object sender, EventArgs e)
        {
            button_symbol_click(RichTextBox1, 'ю', button31, button34);
        }

        private void Button32_Click(object sender, EventArgs e)
        {
            button_symbol_click(RichTextBox1, 'я', button32, button34);
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }
    }

}
