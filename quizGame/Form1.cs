﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizGame
{
    public partial class Form1 : Form
    {

        // variables list for this quiz game
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        int timerSec = 0;
        int MAX_TIME = 60;


        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 5;



        }

        private void ClickAnswerEvent(object sender, EventArgs e)
        {

            var senderObject = (Button)sender;
            timerSec = 0;


            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctAnswer)
            {
                score++;

            }
            question();

        }

        private void question()
        {

            if (questionNumber == totalQuestions)
            {
                // work out the percentage here
                percentage = (int)Math.Round((double)(100 * score) / totalQuestions);


                MessageBox.Show("Quiz Ended" + Environment.NewLine +
                                "Your total percentage is " + percentage + " %" + Environment.NewLine +
                                "Click Ok to play again"

                    );

                score = 0;
                questionNumber = 0;

                askQuestion(questionNumber);
            }

            questionNumber++;

            askQuestion(questionNumber);
        }

        private void askQuestion(int qnum)
        {

            

            switch(qnum)
            {

                case 1:
                    lblQuestion.Text = "What is the capital of France?";

                    button1.Text = "London";
                    button2.Text = "Berlin";
                    button3.Text = "Paris";
                    button4.Text = "Madrid";

                    correctAnswer = 3;

                    break;
                case 2:
                    lblQuestion.Text = "Which planet is known as the \"Red Planet\"?";

                    button1.Text = "Venus";
                    button2.Text = "Earth";
                    button3.Text = "Mars";
                    button4.Text = "Jupiter";

                    correctAnswer = 3;

                    break;

                case 3:


                    lblQuestion.Text = "What is the chemical symbol for gold?";

                    button1.Text = "Go";
                    button2.Text = "Ge";
                    button3.Text = "Au";
                    button4.Text = "Ae";

                    correctAnswer = 3;

                    break;

                case 4:


                    lblQuestion.Text = "Which is the captial city of USA?";

                    button1.Text = "Birmingham";
                    button2.Text = "London";
                    button3.Text = "New york";
                    button4.Text = "Washington D.C";

                    correctAnswer = 4;

                    break;

                case 5:


                    lblQuestion.Text = "Who is the author of \"To Kill a Mockingbird\"?";

                    button1.Text = "J.K. Rowling";
                    button2.Text = "George Orwell";
                    button3.Text = "Harper Lee";
                    button4.Text = "Charles Dickens";

                    correctAnswer = 3;

                    break;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timerSec <= MAX_TIME)
            {
                timerSec++; 
            }
            else
            {
                timerSec = 0;
                question();


            }
        }
    }
}
