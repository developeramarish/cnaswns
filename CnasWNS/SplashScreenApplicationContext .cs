﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Cnas.wns
{

    public abstract class SplashScreenApplicationContext : ApplicationContext
    {

        
        private Form _SplashScreenForm;//启动欢迎窗体 

        private Form _PrimaryForm;//主窗体 

        private System.Timers.Timer _SplashScreenTimer;

        private int _SplashScreenTimerInterVal = 5000;//默认是启动窗体显示5秒 

        private bool _bSplashScreenClosed = false;

        private delegate void DisposeDelegate();//关闭委托，下面需要使用控件的Invoke方法，该方法需要这个委托 



        public SplashScreenApplicationContext()
        {

            this.ShowSplashScreen();//这里创建和显示启动窗体 
            this.MainFormLoad();//这里创建和显示启动主窗体 
        }



        protected abstract void OnCreateSplashScreenForm();
        protected abstract void OnCreateMainForm();
        protected abstract void SetSeconds();

        
        protected Form SplashScreenForm
        {

            set
            {
                this._SplashScreenForm = value;
            }

        }



        public Form PrimaryForm
        {
            //在派生类中重写OnCreateMainForm方法，在MainFormLoad方法中调用OnCreateMainForm方法 
            //  ,在这里才会真正调用Form1(主窗体)的构造函数，即在启动窗体显示后再调用主窗体的构造函数 
            //  ，以避免这种情况:主窗体构造所需时间较长,在屏幕上许久没有响应，看不到启动窗体       
            set
            {
                this._PrimaryForm = value;
            }

        }



        protected int SecondsShow
        {
            //未设置启动画面停留时间时，使用默认时间 
            set
            {
                if (value != 0)
                {
                    this._SplashScreenTimerInterVal = 1000 * value;
                }
            }

        }



        private void ShowSplashScreen()
        {

            try
            {
                this.SetSeconds();

                this.OnCreateSplashScreenForm();
                this._SplashScreenTimer = new System.Timers.Timer(((double)(this._SplashScreenTimerInterVal)));
                _SplashScreenTimer.Elapsed += new System.Timers.ElapsedEventHandler(new System.Timers.ElapsedEventHandler(this.SplashScreenDisplayTimeUp));
                this._SplashScreenTimer.AutoReset = false;
                Thread DisplaySpashScreenThread = new Thread(new ThreadStart(DisplaySplashScreen));
                DisplaySpashScreenThread.Start();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message + "ShowSplashScreen");
            }
            

        }



        private void DisplaySplashScreen()
        {

            this._SplashScreenTimer.Enabled = true;

            Application.Run(this._SplashScreenForm);

        }



        private void SplashScreenDisplayTimeUp(object sender, System.Timers.ElapsedEventArgs e)
        {

            this._SplashScreenTimer.Dispose();

            this._SplashScreenTimer = null;

            this._bSplashScreenClosed = true;

        }



        private void MainFormLoad()
        {
            try
            {
                this.OnCreateMainForm();

                while (!(this._bSplashScreenClosed))
                {
                    Application.DoEvents();
                }

                DisposeDelegate SplashScreenFormDisposeDelegate = new DisposeDelegate(this._SplashScreenForm.Dispose);

                this._SplashScreenForm.Invoke(SplashScreenFormDisposeDelegate);

                this._SplashScreenForm = null;

                //必须先显示，再激活，否则主窗体不能在启动窗体消失后出现 
                this._PrimaryForm.Show();
                this._PrimaryForm.Activate();

                this._PrimaryForm.Closed += new EventHandler(_PrimaryForm_Closed);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message + "MainFormLoad");
            }
            

        }


        private void _PrimaryForm_Closed(object sender, EventArgs e)
        {
            base.ExitThread();
        } 



    }
}
