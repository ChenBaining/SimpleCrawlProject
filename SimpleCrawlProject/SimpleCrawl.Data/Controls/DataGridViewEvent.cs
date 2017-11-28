using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCrawl.Data.Controls
{
    public class DataGridViewEvent
    {
        public DataTable GetDgvToTable (DataGridView dgv)
        {
            DataTable dt = new DataTable();
            for (int count = 0 ; count < dgv.Columns.Count ; count++)
            {
                DataColumn dc = new DataColumn(dgv.Columns[count].Name.ToString());
                dt.Columns.Add(dc);
            }
            for (int count = 0 ; count < dgv.Rows.Count ; count++)
            {
                DataRow dr = dt.NewRow();
                for (int countsub = 0 ; countsub < dgv.Columns.Count ; countsub++)
                {
                    if (dgv.Rows[count].Cells[countsub] is DataGridViewComboBoxCell)
                    {
                       dr[countsub] = Convert.ToString(( dgv.Rows[count].Cells[countsub] as DataGridViewComboBoxCell ).Value);
                    }
                    else
                    {
                        dr[countsub] = Convert.ToString(dgv.Rows[count].Cells[countsub].Value);
                    }
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }



    }
}
