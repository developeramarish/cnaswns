﻿using Cnas.wns.CnasBaseClassClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cnas.wns.CnasHCSManagerUC
{
    public partial class HCSCM_washing_device_procedure_new : Form
    {
        SortedList sl_type = new SortedList();
        SortedList sl_type_01 = new SortedList();
        private string Strselectid = "";
        private string Strselectname = "";
        private string Washer_id = "";//清洗机的ID
        private string Program_name = "";//程序名字
        //系统名称
        string styStemName = ConfigurationManager.AppSettings["SystemName"].ToString();
        public HCSCM_washing_device_procedure_new(SortedList SLdata, DataRow[] arrayDR, DataTable getdt, string was_id)
        {
            InitializeComponent();
            Washer_id = was_id;
            this.Text = styStemName + "--新增清洗流程";
            foreach (DataRow dr in arrayDR)
            {

                sl_type.Add(dr["key_code"].ToString().Trim(), dr["value_code"].ToString().Trim());
                this.cb_type.Items.Add(dr["key_code"].ToString().Trim() + ":" + dr["value_code"].ToString().Trim());

            }
            if (getdt != null)
            {
                int ii = getdt.Rows.Count;
                if (ii <= 0) return;
                for (int i = 0; i < ii; i++)
                {
                    if (getdt.Rows[i]["id"].ToString() != null && getdt.Rows[i]["pr_name"].ToString().Trim() != null)
                    {
                        sl_type_01.Add(getdt.Rows[i]["id"].ToString().Trim(), getdt.Rows[i]["pr_name"].ToString().Trim());
                        cb_program.Items.Add(getdt.Rows[i]["pr_name"].ToString().Trim());
                    }
                }
            }


            if (SLdata != null)//在窗体上显示信息
            {
                this.Text = styStemName + "--修改清洗流程";
                Strselectid = SLdata["id"].ToString();
                Strselectname = this.tb_name.Text = SLdata["dp_name"].ToString();
                this.tb_barcode.Text = SLdata["bar_code"].ToString();
                this.tb_remarks.Text = SLdata["ca_remarks"].ToString();
                this.tb_run_time.Text = SLdata["run_time"].ToString();
                this.cb_program.Text = SLdata["p_id"].ToString();
                Program_name = SLdata["p_id"].ToString();
                this.cb_type.Text = sl_type.GetKey(sl_type.IndexOfValue(SLdata["p_type"].ToString())) + ":" + SLdata["p_type"].ToString();
            }

        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void but_ok_Click(object sender, EventArgs e)
        {
            DataTable getdt = new DataTable();
            if (this.tb_name.Text.Trim() == "")
            {
                MessageBox.Show("请填写清洗流程名称。", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (this.cb_program.SelectedItem == null)
            {
                MessageBox.Show("请选择清洗程序。", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (this.cb_type.SelectedItem == null)
            {
                MessageBox.Show("请选择清洗类型。", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //如果用户输入的值不为正整数，则提示用户
            if (!CnasUtilityTools.IsNumeric(tb_run_time.Text))
            {
                MessageBox.Show("运行时间输入的格式不正确，请输入正整数。", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {

                CnasRemotCall reCnasRemotCall = new CnasRemotCall();
                SortedList sttemp01 = new SortedList();
                sttemp01.Add(1, Washer_id);
                getdt = reCnasRemotCall.RemotInterface.SelectData("HCS-washing-deviceprogram-sec001", sttemp01);//91
                if (Strselectid == "")//增加
                {

                    #region 判断这台清洗机的清洗程序是否重复

                    if (getdt != null)
                    {
                        int ii = getdt.Rows.Count;
                        if (ii <= 0) return;
                        for (int i = 0; i < ii; i++)
                        {
                            if (getdt.Rows[i]["p_id"].ToString() != null)
                            {
                                if (sl_type_01.GetKey(sl_type_01.IndexOfValue(cb_program.Text.Trim())).ToString() == getdt.Rows[i]["p_id"].ToString().Trim())
                                {
                                    MessageBox.Show("清洗程序已存在。", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                            }
                        }
                    }
                    #endregion

                    #region 判断名字是否重复

                    if (getdt != null)
                    {
                        int ii = getdt.Rows.Count;
                        if (ii <= 0) return;
                        for (int i = 0; i < ii; i++)
                        {
                            if (getdt.Rows[i]["p_id"].ToString() != null)
                            {
                                if (tb_name.Text.Trim().ToString() == getdt.Rows[i]["dp_name"].ToString().Trim())
                                {
                                    MessageBox.Show("清洗流程名称已存在。", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                            }
                        }
                    }
                    #endregion
                    SortedList sltmp = new SortedList();
                    SortedList sltmp01 = new SortedList();
                    sltmp.Add(1, tb_name.Text.Trim());

                    sltmp.Add(2, tb_barcode.Text.Trim());



                    sltmp.Add(3, sl_type_01.GetKey(sl_type_01.IndexOfValue(cb_program.Text.Trim())).ToString());

                    sltmp.Add(4, cb_type.Text.Trim().Substring(0, 1));
                    sltmp.Add(5, tb_run_time.Text.Trim());
                    sltmp.Add(6, tb_remarks.Text.Trim());
                    sltmp.Add(7, Washer_id);

                    sltmp01.Add(1, sltmp);


                    // string strtmp = reCnasRemotCall.RemotInterface.CheckUPData(1, "hcs_washing_deviceprogram_add001", sltmp01, null);
                    int recint = reCnasRemotCall.RemotInterface.UPData(1, "HCS-washing-deviceprogram-add001", sltmp01, null);
                    if (recint > -1)
                    {
                        MessageBox.Show("恭喜你，增加成功。", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {

                    if (cb_program.Text.Trim() != Program_name)//如果清洗程序被改变执行
                    {
                        #region 判断这台清洗机的清洗程序是否重复
                        if (getdt != null)
                        {
                            int ii = getdt.Rows.Count;
                            if (ii <= 0) return;
                            for (int i = 0; i < ii; i++)
                            {
                                if (getdt.Rows[i]["p_id"].ToString() != null)
                                {
                                    if (sl_type_01.GetKey(sl_type_01.IndexOfValue(cb_program.Text.Trim())).ToString() == getdt.Rows[i]["p_id"].ToString().Trim())
                                    {
                                        MessageBox.Show("清洗程序已存在。", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        return;
                                    }
                                }
                            }
                        }
                        #endregion
                    }




                    #region 判断名字是否存在


                    if (this.tb_name.Text.Trim() != Strselectname)
                    {
                        if (getdt != null)
                        {
                            int ii = getdt.Rows.Count;
                            if (ii <= 0) return;
                            for (int i = 0; i < ii; i++)
                            {
                                if (getdt.Rows[i]["p_id"].ToString() != null)
                                {
                                    if (tb_name.Text.Trim().ToString() == getdt.Rows[i]["dp_name"].ToString().Trim())
                                    {
                                        MessageBox.Show("名字已存在", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        return;
                                    }
                                }
                            }
                        }
                    }

                    #endregion

                    SortedList sltmp = new SortedList();
                    SortedList sltmp01 = new SortedList();
                    sltmp01.Add(1, tb_name.Text.Trim());

                    sltmp01.Add(2, sl_type_01.GetKey(sl_type_01.IndexOfValue(cb_program.Text.Trim())));
                    sltmp01.Add(3, cb_type.Text.Trim().Substring(0, 1));
                    sltmp01.Add(4, tb_run_time.Text.Trim());
                    sltmp01.Add(5, tb_remarks.Text.Trim());

                    sltmp01.Add(6, Strselectid);
                    sltmp.Add(1, sltmp01);


                    // string sql = reCnasRemotCall.RemotInterface.CheckUPData(1, "hcs_washing_deviceprogram_up001", sltmp, null);
                    int recint = reCnasRemotCall.RemotInterface.UPData(1, "HCS-washing-deviceprogram-up001", sltmp, null);
                    if (recint > -1)
                    {
                        MessageBox.Show("恭喜你，修改成功。", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("出现未知错误：" + ex.Message + ",请联系管理员。", "错误信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

















        }



        private void but_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
