using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_game_design_and_coded_solution
{
    public partial class Entertainment : Form
    {
        // quiz game variables

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;



        public Entertainment()
        {
            
            InitializeComponent();
            askQuestion(1);
            totalQuestions = 10;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctAnswer)
            {
                score = score + 1;
            }

            questionNumber++;
            askQuestion(questionNumber);

            if (questionNumber == totalQuestions)
            {
                // Working out the percentage 

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                // this will display when the quiz has ended 
                MessageBox.Show("Quiz Ended!" + Environment.NewLine + "You have answered " + score + "questions correctly" + Environment.NewLine +
                    "Your total percentage is" + percentage + "%" + Environment.NewLine +
                    "Click OK to play again");
                score = 0; // this will reset the code to 0
                questionNumber = 0;
                askQuestion(questionNumber);
            }
        }

        private void askQuestion(int qnum) 
        {
            switch (qnum)  // to allow it to select many code blocks to be executed
            {
                case 1: // question one 
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "'The Monster Mash' was a big hit for Boris Pickett and WHO?"; // the question asked to the user

                    button1.Text = "The Crypt Kickers"; // option 1
                    button2.Text = "The Grave Diggers"; // option 2
                    button3.Text = "The Tomb Raiders"; // option 3
                    button4.Text = "The Undead"; // option 4

                    correctAnswer = 1; // the correct answer would option 1


                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "Who had the movie line 'Charlie don't surf'?"; // the second question that is asked to the user

                    button1.Text = "Michelle Rodriguez in 'Blue Crush'"; // option 1
                    button2.Text = "Robert Duvall in 'Apocalypse Now' "; // option 2
                    button3.Text = "Keanu Reeves in 'Point Break'"; // option 3
                    button4.Text = "Gary Busey in 'Big Wednesday'"; // option 4

                    correctAnswer = 2; // the correct answer would be the second option in this case

                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "Which actor stars in the 2007 film \"Sweeney Todd: The Demon Barber of Fleet Street\"?"; // the third question that is asked to the user

                    button1.Text = "Clive Owen"; // option 1
                    button2.Text = "Jim Carrey"; // option 2
                    button3.Text = "Johnny Depp"; // option 3
                    button4.Text = "Jude Law"; // option 4

                    correctAnswer = 3; // the correct answer would be four in this case
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "Who starred in the 2003 movie \"School Of Rock\"?"; // the third question that is asked to the user

                    button1.Text = "Kyle Gass"; // option 1
                    button2.Text = "Jack Black"; // option 2
                    button3.Text = "Dana Carvey"; // option 3
                    button4.Text = "Mike Myers"; // option 4

                    correctAnswer = 2; // the correct answer would be four in this case
                    break;





                case 5:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "Which English musician did model Jerry Hall leave for Mick Jagger?"; // the third question that is asked to the user

                    button1.Text = "David Bowie"; // option 1
                    button2.Text = "Paul McCartney"; // option 2
                    button3.Text = "Bryan Ferry"; // option 3
                    button4.Text = "Ringo Starr"; // option 4

                    correctAnswer = 3; // the correct answer would be four in this case
                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "What was the name of Richie's family in TV's \"Happy Days\"?"; // the third question that is asked to the user

                    button1.Text = "Ricardo"; // option 1
                    button2.Text = "Henderson"; // option 2
                    button3.Text = "Cunningham"; // option 3
                    button4.Text = "Richardson"; // option 4

                    correctAnswer = 3; // the correct answer would be four in this case
                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "Which of these films has NOT starred Olivia Newton-John?"; // the third question that is asked to the user

                    button1.Text = "Grease"; // option 1
                    button2.Text = "Two Of A Kind"; // option 2
                    button3.Text = "Xanadu"; // option 3
                    button4.Text = "The Man From Snowy River"; // option 4

                    correctAnswer = 4; // the correct answer would be four in this case
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "The US TV show \"Don't Forget The Lyrics\" has been hosted by WHAT comedian?"; // the third question that is asked to the user

                    button1.Text = "Joey Fatone"; // option 1
                    button2.Text = "Sue Barker"; // option 2
                    button3.Text = "Wayne Brady"; // option 3
                    button4.Text = "Peter Berner"; // option 4

                    correctAnswer = 3; // the correct answer would be four in this case
                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "Which Spanish city does the waiter Manuel from TV's \"Fawlty Towers\" come from?"; // the third question that is asked to the user

                    button1.Text = "Madrid"; // option 1
                    button2.Text = "Seville"; // option 2
                    button3.Text = "Barcelona"; // option 3
                    button4.Text = "Pamplona"; // option 4

                    correctAnswer = 3; // the correct answer would be four in this case
                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "Which beer 'Refreshes the parts other beers cannot reach'?"; // the third question that is asked to the user

                    button1.Text = "Guinness"; // option 1
                    button2.Text = "Carlsberg"; // option 2
                    button3.Text = "Fosters"; // option 3
                    button4.Text = "Heineken"; // option 4

                    correctAnswer = 4; // the correct answer would be four in this case
                    break;


            }
        }
    }
   }

