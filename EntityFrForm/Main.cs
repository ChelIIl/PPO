using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrForm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            List<Cars> li = new List<Cars>();
            Cars c = new Cars();
            c.update(li);
            AllCarsTable.DataSource = li;
            Mark_t.ReadOnly = true;
            colour_t.ReadOnly = true;
            year_t.ReadOnly = true;
            mileage_t.ReadOnly = true;
            allResButton.Text = "";
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            using (UserContext db = new UserContext())
            {
                List<Cars> l = new List<Cars>();
                Cars cc = new Cars();
                cc.update(l);

                foreach (DataGridViewRow drv in AllCarsTable.SelectedRows)
                {
                    int index = drv.Index;
                    int val = l[index].id;
                    cc = db.Cars
                        .Where(j => j.id == val)
                        .FirstOrDefault();
                    db.Cars.Remove(cc);
                    db.SaveChanges();
                    cc.update(l);
                    AllCarsTable.DataSource = l;
                    break;
                }
            }
        }

        private void check_add_CheckedChanged(object sender, EventArgs e)
        {
            if (check_add.Checked)
            {
                Mark_t.ReadOnly = false;
                colour_t.ReadOnly = false;
                year_t.ReadOnly = false;
                mileage_t.ReadOnly = false;
                Mark_t.Text = "";
                year_t.Text = "";
                mileage_t.Text = "";
                colour_t.Text = "";
                allResButton.Text = "Добавить";
                check_change.CheckState = CheckState.Unchecked;
                check_delete.CheckState = CheckState.Unchecked;
                check_search.CheckState = CheckState.Unchecked;
            }
        }

        private void check_delete_CheckedChanged(object sender, EventArgs e)
        {
            if (check_delete.Checked)
            {
                Mark_t.ReadOnly = true;
                colour_t.ReadOnly = true;
                year_t.ReadOnly = true;
                mileage_t.ReadOnly = true;
                Mark_t.Text = "";
                year_t.Text = "";
                mileage_t.Text = "";
                colour_t.Text = "";
                allResButton.Text = "Удалить";
                check_change.CheckState = CheckState.Unchecked;
                check_add.CheckState = CheckState.Unchecked;
                check_search.CheckState = CheckState.Unchecked;
            }
        }

        private void check_change_CheckedChanged(object sender, EventArgs e)
        {
            if (check_change.Checked)
            {
                Mark_t.ReadOnly = false;
                colour_t.ReadOnly = false;
                year_t.ReadOnly = false;
                mileage_t.ReadOnly = false;
                allResButton.Text = "Изменить";
                check_delete.CheckState = CheckState.Unchecked;
                check_add.CheckState = CheckState.Unchecked;
                check_search.CheckState = CheckState.Unchecked;
            }
        }

        private void check_search_CheckedChanged(object sender, EventArgs e)
        {
            if (check_search.Checked)
            {
                Mark_t.ReadOnly = false;
                colour_t.ReadOnly = false;
                year_t.ReadOnly = true;
                mileage_t.ReadOnly = true;
                Mark_t.Text = "";
                year_t.Text = "";
                mileage_t.Text = "";
                colour_t.Text = "";
                allResButton.Text = "Поиск";
                check_delete.CheckState = CheckState.Unchecked;
                check_add.CheckState = CheckState.Unchecked;
                check_change.CheckState = CheckState.Unchecked;
            }
        }

        private void allResButton_Click(object sender, EventArgs e)
        {
            if (check_add.Checked)
            {
                List<Cars> li = new List<Cars>();
                Cars c = new Cars();
                string mark = Convert.ToString(Mark_t.Text);
                int year = Convert.ToInt32(year_t.Text);
                int probeg = Convert.ToInt32(mileage_t.Text);
                string colour = Convert.ToString(colour_t.Text);

                c.addCar(mark, year, probeg, colour);
                c.update(li);
                AllCarsTable.DataSource = li;
            }

            else if (check_delete.Checked)
            {
                using (UserContext db = new UserContext())
                {
                    List<Cars> l = new List<Cars>();
                    Cars cc = new Cars();
                    cc.update(l);

                    foreach (DataGridViewRow drv in AllCarsTable.SelectedRows)
                    {
                        int index = drv.Index;
                        int val = l[index].id;
                        cc = db.Cars
                            .Where(j => j.id == val)
                            .FirstOrDefault();
                        db.Cars.Remove(cc);
                        db.SaveChanges();
                        cc.update(l);
                        AllCarsTable.DataSource = l;
                        break;
                    }
                }
            }

            else if (check_search.Checked)
            {
                List<Cars> li = new List<Cars>();
                List<Cars> l = new List<Cars>();
                Cars ca = new Cars();
                ca.update(li);

                if (Mark_t.Text != "" && colour_t.Text != "")
                {
                    l.Clear();
                    for (int i = 0; i < li.Count; i++)
                    {
                        if (Mark_t.Text == li[i].mark && colour_t.Text == li[i].colour)
                        {
                            l.Add(li[i]);
                        }
                    }
                    AllCarsTable.DataSource = l;
                    AllCarsTable.Refresh();
                }

                else if (Mark_t.Text != "")
                {
                    l.Clear();
                    for (int i = 0; i < li.Count; i++)
                    {
                        if (Mark_t.Text == li[i].mark)
                        {
                            l.Add(li[i]);
                        }
                    }
                    AllCarsTable.DataSource = l;
                    AllCarsTable.Refresh();
                }

                else if (colour_t.Text != "")
                {
                    l.Clear();
                    for (int i = 0; i < li.Count; i++)
                    {
                        if (colour_t.Text == li[i].colour)
                        {
                            l.Add(li[i]);
                        }
                    }
                    AllCarsTable.DataSource = l;
                    AllCarsTable.Refresh();
                }
            }

            else if (check_change.Checked)
            {
                using (UserContext db = new UserContext())
                {
                    List<Cars> li = new List<Cars>();
                    Cars ca = new Cars();
                    ca.update(li);

                    int index = AllCarsTable.CurrentCell.RowIndex;

                    li[index].mark = Mark_t.Text;
                    li[index].colour = colour_t.Text;
                    li[index].probeg = Convert.ToInt32(mileage_t.Text);
                    li[index].year = Convert.ToInt32(year_t.Text);

                    List<Cars> l = new List<Cars>();
                    ca.update(l);
                    int val = li[index].id;

                    ca = db.Cars
                          .Where(j => j.id == val)
                          .FirstOrDefault();
                    ca.mark = li[index].mark;
                    ca.colour = li[index].colour;
                    ca.probeg = li[index].probeg;
                    ca.year = li[index].year;
                    db.SaveChanges();
                    ca.update(li);
                }
            }
        }

        private void AllCarsTable_SelectionChanged(object sender, EventArgs e)
        {
            if (check_change.Checked)
            {
                List<Cars> li = new List<Cars>();
                Cars c = new Cars();
                c.update(li);
                Mark_t.ReadOnly = false;
                colour_t.ReadOnly = false;
                year_t.ReadOnly = false;
                mileage_t.ReadOnly = false;

                int index = AllCarsTable.CurrentCell.RowIndex;

                Mark_t.Text = li[index].mark;
                colour_t.Text = li[index].colour;
                mileage_t.Text = Convert.ToString(li[index].probeg);
                year_t.Text = Convert.ToString(li[index].year);
            }
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            List<Cars> li = new List<Cars>();
            Cars c = new Cars();
            c.update(li);
            AllCarsTable.DataSource = li;
        }

        private void car_info_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drv in AllCarsTable.SelectedRows)
            {
                string index = Convert.ToString(drv.Index);
                INFO inf = new INFO(index);
                inf.Show();
            }
        }
    }
}