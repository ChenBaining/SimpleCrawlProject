using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCrawl.Data.Controls
{
    public class ComboBoxEvent
    {
        private int comboBoxColumnIndex;
        private DataGridView dgv;
        private ComboBox comboBox;
        private bool DroppedDown ,loadComboBox , isLoadSelectChange;
        public event EventHandler SelectedIndexChanged;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="comboBoxColumnIndex">需要下拉框的DataGridView 下角标位置</param>
        /// <param name="dgv">需要下拉框的DataGridView</param>
        /// <param name="comboBox">下拉框</param>
        /// <param name="DroppedDown">下拉框是否默认是下拉状态 </param>
        public ComboBoxEvent (int comboBoxColumnIndex , DataGridView dgv , ComboBox comboBox , bool DroppedDown =false , bool isLoadSelectChange =false)
        {
            dgv.Controls.Add(comboBox);
            this.comboBoxColumnIndex = comboBoxColumnIndex;
            this.dgv = dgv;
            this.comboBox = comboBox;
            this.DroppedDown = DroppedDown;
            this.isLoadSelectChange = isLoadSelectChange;
            loadComboBox = false;
        }

        #region 设置点击和移开事件
        public void dataGridView_CellEnter (object sender , DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == comboBoxColumnIndex && loadComboBox)
            {
                //此处cell即CurrentCell
                DataGridViewCell cell = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex];
                Rectangle rect = dgv.GetCellDisplayRectangle(cell.ColumnIndex , cell.RowIndex , true);
                comboBox.Location = rect.Location;
                comboBox.Size = rect.Size;
                if (isLoadSelectChange && SelectedIndexChanged!=null)
                {
                    comboBox.SelectedIndexChanged += SelectedIndexChanged;
                }
                
                if (DroppedDown)
                {
                    comboBox.DroppedDown = true;//默认是下拉状态
                }
                comfirmComboBoxValue(comboBox , (String)cell.Value);
                comboBox.Visible = true;
            }
            else
            {
                loadComboBox = true;
            }


            dgv[e.ColumnIndex , e.RowIndex].Style.SelectionBackColor = Color.Blue;//设置背景颜色
        }

        public void dataGridView_CellLeave (object sender , DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == comboBoxColumnIndex)
            {
                //此处cell不为CurrentCell
                DataGridViewCell cell = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.Value = comboBox.Text;
                comboBox.Visible = false;
            }



            dgv[e.ColumnIndex , e.RowIndex].Style.SelectionBackColor = Color.Empty;  //取消背景颜色
        }

        private void comfirmComboBoxValue (ComboBox com , String cellValue)
        {
            com.SelectedIndex = 0;
            if (cellValue == null)
            {
                com.Text = "";
                return;
            }
            com.Text = cellValue;
            foreach (Object item in com.Items)
            {
                if ((String)item == cellValue)
                {
                    com.DisplayMember = item.ToString();
                    break;
                }
            }
        }
        #endregion

        #region 设置下拉框自动变宽AutoSizeComboBoxItem
        /// <summary>
        /// 自动改变CombBox控件下拉框的宽度，
        /// ComboBox控件的DropDown事件中调用本方法。
        /// </summary>
        /// <param name="sender"> ComboBox对象</param>
        public void AutoSizeComboBoxItem (object sender , EventArgs e)
        {
            if (sender is ComboBox)
            {

                Graphics grap = Graphics.FromHwnd(( sender as ComboBox ).Handle);
                StringFormat sf = new StringFormat(StringFormat.GenericTypographic);
                SizeF size;
                int i = 0;
                int extraWidth = 6;//额外宽度
                if (( sender as ComboBox ).MaxDropDownItems < ( sender as ComboBox ).Items.Count)
                {
                    //可以采用下面三行代码自动获取系统设置的垂直滚动条宽度，单个人觉得过犹不及。 comment by Dominic
                    //VScrollBar vScrollBar = new VScrollBar();
                    //extraWidth += vScrollBar.Width; //取系统垂直滚动条宽度。
                    //vScrollBar.Dispose();
                    extraWidth += 18; //预留18px的滚动条条宽度。
                }

                while (i < ( sender as ComboBox ).Items.Count)
                {

                    size = grap.MeasureString(( sender as ComboBox ).Items[i].ToString() , ( sender as ComboBox ).Font , 500 , sf);
                    if (size.Width > ( sender as ComboBox ).DropDownWidth - extraWidth)
                    {
                        ( sender as ComboBox ).DropDownWidth = System.Convert.ToInt32(size.Width) + extraWidth;
                    }
                    i++;
                }
                grap.Dispose();
                sf.Dispose();
            }

        }
        #endregion //AutoSizeComboBoxItem


        #region datagridview点击事件
        public void dataGridView_CellClick (object sender , DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (e.ColumnIndex == comboBoxColumnIndex)
                {
                    //此处cell即CurrentCell
                    DataGridViewCell cell = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    Rectangle rect = dgv.GetCellDisplayRectangle(cell.ColumnIndex , cell.RowIndex , true);
                    comboBox.Location = rect.Location;
                    comboBox.Size = rect.Size;
                    if (DroppedDown)
                    {
                        //comboBox.DroppedDown = true;//默认是下拉状态
                    }
                    comfirmComboBoxValue(comboBox , (String)cell.Value);
                    comboBox.Visible = true;

                }
            }
        }
        #endregion




    }
}
