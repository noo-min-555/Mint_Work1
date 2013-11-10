using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ms = "ตัวเลือกที่คุณเลือกคือ :"+ Environment .NewLine ;
           
            //เพศ
            if (radioButton1.Checked == true)
            {
                ms = ms + "เพศ : ชาย"+ Environment .NewLine ;
            }
            else
                ms = ms + "เพศ : หญิง"+ Environment .NewLine ;
            //ความเครียดส่งผลต่อชีวิตประจำวันมากหรือไม่
            if (radioButton3.Checked == true)
            {
                ms = ms + "ความเครียดส่งผลต่อชีวิตประจำวันมากหรือไม่ : มาก" + Environment.NewLine;
            }
            else if (radioButton4.Checked == true)
            {
                ms = ms + "ความเครียดส่งผลต่อชีวิตประจำวันมากหรือไม่ : ปานกลาง" + Environment.NewLine;
            }
            else if (radioButton5.Checked == true)
            {
                ms = ms + "ความเครียดส่งผลต่อชีวิตประจำวันมากหรือไม่ : น้อย" + Environment.NewLine;
            }
            else if (radioButton6.Checked == true)
            {
                ms = ms + "ความเครียดส่งผลต่อชีวิตประจำวันมากหรือไม่ : ไม่ส่งผลเลย" + Environment.NewLine;
            }
            else if (radioButton7.Checked == true)
            {
                if (textBox1.Text == "")
                {
                    ms = ms + "ความเครียดส่งผลต่อชีวิตประจำวันมากหรือไม่ : อื่น ๆ : กรุณกรอกข้อมูลด้วย" + Environment.NewLine;
                }
                else
                {
                    ms = ms + "ความเครียดส่งผลต่อชีวิตประจำวันมากหรือไม่ : อื่น ๆ : " + textBox1.Text + Environment.NewLine;
                }
            }
            else
            {
                ms = ms + "ความเครียดส่งผลต่อชีวิตประจำวันมากหรือไม่ : มาก" + Environment.NewLine;
            }
    //ท่านมีความเครียดด้านใดบ้าง
            if (radioButton8.Checked == true)
            {
                ms = ms + "ท่านมีความเครียดด้านใดบ้าง : ครอบครัว" + Environment.NewLine;
            }
            else if (radioButton9.Checked == true)
            {
                ms = ms + "ท่านมีความเครียดด้านใดบ้าง : เพื่อน" + Environment.NewLine;
            }
            else if (radioButton10.Checked == true)
            {
                ms = ms + "ท่านมีความเครียดด้านใดบ้าง : การเมือง" + Environment.NewLine;
            }
            else if (radioButton11.Checked == true)
            {
                ms = ms + "ท่านมีความเครียดด้านใดบ้าง : การเรียน" + Environment.NewLine;
            }
            else if (radioButton12.Checked == true)
            {
                ms = ms + "ท่านมีความเครียดด้านใดบ้าง : ความรัก" + Environment.NewLine;
            }
            else if (radioButton13.Checked == true)
            {
                ms = ms + "ท่านมีความเครียดด้านใดบ้าง : สภาพอากาศ" + Environment.NewLine;
            }
            else if (radioButton14.Checked == true)
            {
                ms = ms + "ท่านมีความเครียดด้านใดบ้าง : การเงิน" + Environment.NewLine;
            }
            else if (radioButton15.Checked == true)
            {
                if (textBox2.Text == "")
                {
                    ms = ms + "ท่านมีความเครียดด้านใดบ้าง : อื่น ๆ : กรุณากรอกข้อมูล" + Environment.NewLine;
                }
                else
                {
                    ms = ms + "ท่านมีความเครียดด้านใดบ้าง : อื่น ๆ " + textBox2.Text + Environment.NewLine;
                }
            }
            else
            {
                ms = ms + "ท่านมีความเครียดด้านใดบ้าง : ครอบครัว" + Environment.NewLine;
            }
            //มีวิธีแก้ปัญหาความเครียดอย่างไร
            if (radioButton16.Checked == true)
            {
                ms = ms + "มีวิธีแก้ปัญหาความเครียดอย่างไร : ปรึกษาเพือน"+ Environment.NewLine;
            }
            else if (radioButton17.Checked == true)
            {
                ms = ms + "มีวิธีแก้ปัญหาความเครียดอย่างไร : ปรึกษาครอบครัว"+ Environment.NewLine;
            }
            else if (radioButton18.Checked == true)
            {
                ms = ms + "มีวิธีแก้ปัญหาความเครียดอย่างไร : ปรึกษาครูบาร์อาจารย์"+ Environment.NewLine;
            }
            else if (radioButton19.Checked == true)
            {
                ms = ms + "มีวิธีแก้ปัญหาความเครียดอย่างไร : ปรึกษาจิตแพทย์"+ Environment.NewLine;
            }
            else if (radioButton20.Checked == true)
            {
                ms = ms + "มีวิธีแก้ปัญหาความเครียดอย่างไร : เก็บไว้คนเดียว"+ Environment.NewLine;
            }
            else if (radioButton21 .Checked == true )
            {
                if (textBox3 .Text =="")
                {
                    ms = ms + "มีวิธีแก้ปัญหาความเครียดอย่างไร : อื่น ๆ : กรุณากรอกข้อมูล" + Environment.NewLine;
                }
                else 
                {
                    ms = ms + "มีวิธีแก้ปัญหาความเครียดอย่างไร : อื่น ๆ " + textBox3.Text + Environment.NewLine;
                }
            }
            else 
            {
                ms = ms + "มีวิธีแก้ปัญหาความเครียดอย่างไร : ปรึกษาเพือน" + Environment.NewLine;
            }
            MessageBox.Show(ms, "คำตอบของคุณ" );

        }
    }
}
