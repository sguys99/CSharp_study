﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch20queue_stack
{
    public partial class Form1 : Form
    {
        Queue<int> _Queue = new Queue<int>(6);
        Stack<int> _Stack = new Stack<int>(6); // 생성 및 초기화

        Timer _oTimer = new Timer();
        bool _bTimer = false; //타이머 스위치

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDataIn_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int iData = rd.Next(1, 101); // 지정된 범위 내 정수 반환

            if (_Queue.Count < 6)
            {
                _Queue.Enqueue(iData);
                fQueueDataDisplay();
            }

            if (_Stack.Count < 6)
            {
                _Stack.Push(iData);
                fStackDataDisplay();
            }
        }

        private void btnAutoDataOut_Click(object sender, EventArgs e)
        {
            if (_bTimer)
            {
                _oTimer.Stop();
                _bTimer = false;
            }
           else
            {
                _oTimer.Interval = 2000;//2초 주기로 이벤트 발생
                _oTimer.Tick += _oTimer_Tick;
                _oTimer.Start();

                _bTimer = true;
            }
        }

        private void _oTimer_Tick(object sender, EventArgs e)
        {
            fDataOut();
        }

        private void btnDataOut_Click(object sender, EventArgs e)
        {
            fDataOut();
        }

        private void fDataOut()
        {
            //Queue에 Data를 입력
            if (_Queue.Count > 0)
            {
                _Queue.Dequeue();
                fQueueDataDisplay();
            }

            //Stack에 Data를 입력
            if (_Stack.Count > 0)
            {
                _Stack.Pop();
                fStackDataDisplay();
            }
        }

        private void fQueueDataDisplay()
        {
            int[] iArray = _Queue.ToArray();

            Array.Resize(ref iArray, 6);// array 사이즈를 6으로 조정 6보다 크면 나머지는 버림

            lblQueue1.Text = (iArray[0] == 0) ? "" : iArray[0].ToString();
            lblQueue2.Text = (iArray[1] == 0) ? "" : iArray[1].ToString();
            lblQueue3.Text = (iArray[2] == 0) ? "" : iArray[2].ToString();
            lblQueue4.Text = (iArray[3] == 0) ? "" : iArray[3].ToString();
            lblQueue5.Text = (iArray[4] == 0) ? "" : iArray[4].ToString();
            lblQueue6.Text = (iArray[5] == 0) ? "" : iArray[5].ToString();
        }

        private void fStackDataDisplay()
        {
            int[] iArray = _Stack.ToArray();

            Array.Resize(ref iArray, 6);

            lblStack1.Text = (iArray[0] == 0) ? "" : iArray[0].ToString();
            lblStack2.Text = (iArray[1] == 0) ? "" : iArray[1].ToString();
            lblStack3.Text = (iArray[2] == 0) ? "" : iArray[2].ToString();
            lblStack4.Text = (iArray[3] == 0) ? "" : iArray[3].ToString();
            lblStack5.Text = (iArray[4] == 0) ? "" : iArray[4].ToString();
            lblStack6.Text = (iArray[5] == 0) ? "" : iArray[5].ToString();
        }
    }
}
