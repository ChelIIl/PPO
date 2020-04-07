namespace EntityFrForm
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllCarsTable = new System.Windows.Forms.DataGridView();
            this.check_search = new System.Windows.Forms.CheckBox();
            this.check_add = new System.Windows.Forms.CheckBox();
            this.check_delete = new System.Windows.Forms.CheckBox();
            this.check_change = new System.Windows.Forms.CheckBox();
            this.allResButton = new System.Windows.Forms.Button();
            this.mileage_t = new System.Windows.Forms.TextBox();
            this.Mileage_car = new System.Windows.Forms.Label();
            this.colour_t = new System.Windows.Forms.TextBox();
            this.Colour_car = new System.Windows.Forms.Label();
            this.year_t = new System.Windows.Forms.TextBox();
            this.Year_car = new System.Windows.Forms.Label();
            this.Mark_t = new System.Windows.Forms.TextBox();
            this.Mark_car = new System.Windows.Forms.Label();
            this.reset_button = new System.Windows.Forms.Button();
            this.car_info = new System.Windows.Forms.Button();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AllCarsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tag";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tag";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // AllCarsTable
            // 
            this.AllCarsTable.AllowUserToAddRows = false;
            this.AllCarsTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.AllCarsTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AllCarsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllCarsTable.Location = new System.Drawing.Point(-2, 181);
            this.AllCarsTable.Name = "AllCarsTable";
            this.AllCarsTable.Size = new System.Drawing.Size(544, 170);
            this.AllCarsTable.TabIndex = 0;
            this.AllCarsTable.SelectionChanged += new System.EventHandler(this.AllCarsTable_SelectionChanged);
            // 
            // check_search
            // 
            this.check_search.AutoSize = true;
            this.check_search.Location = new System.Drawing.Point(23, 106);
            this.check_search.Name = "check_search";
            this.check_search.Size = new System.Drawing.Size(58, 17);
            this.check_search.TabIndex = 5;
            this.check_search.Text = "Поиск";
            this.check_search.UseVisualStyleBackColor = true;
            this.check_search.CheckedChanged += new System.EventHandler(this.check_search_CheckedChanged);
            // 
            // check_add
            // 
            this.check_add.AutoSize = true;
            this.check_add.Location = new System.Drawing.Point(23, 83);
            this.check_add.Name = "check_add";
            this.check_add.Size = new System.Drawing.Size(76, 17);
            this.check_add.TabIndex = 6;
            this.check_add.Text = "Добавить";
            this.check_add.UseVisualStyleBackColor = true;
            this.check_add.CheckedChanged += new System.EventHandler(this.check_add_CheckedChanged);
            // 
            // check_delete
            // 
            this.check_delete.AutoSize = true;
            this.check_delete.Location = new System.Drawing.Point(23, 37);
            this.check_delete.Name = "check_delete";
            this.check_delete.Size = new System.Drawing.Size(69, 17);
            this.check_delete.TabIndex = 7;
            this.check_delete.Text = "Удалить";
            this.check_delete.UseVisualStyleBackColor = true;
            this.check_delete.CheckedChanged += new System.EventHandler(this.check_delete_CheckedChanged);
            // 
            // check_change
            // 
            this.check_change.AutoSize = true;
            this.check_change.Location = new System.Drawing.Point(23, 60);
            this.check_change.Name = "check_change";
            this.check_change.Size = new System.Drawing.Size(77, 17);
            this.check_change.TabIndex = 8;
            this.check_change.Text = "Изменить";
            this.check_change.UseVisualStyleBackColor = true;
            this.check_change.CheckedChanged += new System.EventHandler(this.check_change_CheckedChanged);
            // 
            // allResButton
            // 
            this.allResButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allResButton.Location = new System.Drawing.Point(227, 152);
            this.allResButton.Name = "allResButton";
            this.allResButton.Size = new System.Drawing.Size(103, 23);
            this.allResButton.TabIndex = 9;
            this.allResButton.Text = "Поиск";
            this.allResButton.UseVisualStyleBackColor = true;
            this.allResButton.Click += new System.EventHandler(this.allResButton_Click);
            // 
            // mileage_t
            // 
            this.mileage_t.Location = new System.Drawing.Point(345, 112);
            this.mileage_t.Name = "mileage_t";
            this.mileage_t.Size = new System.Drawing.Size(100, 20);
            this.mileage_t.TabIndex = 17;
            // 
            // Mileage_car
            // 
            this.Mileage_car.AutoSize = true;
            this.Mileage_car.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mileage_car.Location = new System.Drawing.Point(348, 72);
            this.Mileage_car.Name = "Mileage_car";
            this.Mileage_car.Size = new System.Drawing.Size(97, 28);
            this.Mileage_car.TabIndex = 16;
            this.Mileage_car.Text = "Probeg";
            // 
            // colour_t
            // 
            this.colour_t.Location = new System.Drawing.Point(345, 49);
            this.colour_t.Name = "colour_t";
            this.colour_t.Size = new System.Drawing.Size(100, 20);
            this.colour_t.TabIndex = 15;
            // 
            // Colour_car
            // 
            this.Colour_car.AutoSize = true;
            this.Colour_car.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Colour_car.Location = new System.Drawing.Point(348, 9);
            this.Colour_car.Name = "Colour_car";
            this.Colour_car.Size = new System.Drawing.Size(90, 28);
            this.Colour_car.TabIndex = 14;
            this.Colour_car.Text = "Colour";
            // 
            // year_t
            // 
            this.year_t.Location = new System.Drawing.Point(126, 112);
            this.year_t.Name = "year_t";
            this.year_t.Size = new System.Drawing.Size(100, 20);
            this.year_t.TabIndex = 13;
            // 
            // Year_car
            // 
            this.Year_car.AutoSize = true;
            this.Year_car.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year_car.Location = new System.Drawing.Point(142, 72);
            this.Year_car.Name = "Year_car";
            this.Year_car.Size = new System.Drawing.Size(66, 28);
            this.Year_car.TabIndex = 12;
            this.Year_car.Text = "Year";
            // 
            // Mark_t
            // 
            this.Mark_t.Location = new System.Drawing.Point(126, 49);
            this.Mark_t.Name = "Mark_t";
            this.Mark_t.Size = new System.Drawing.Size(100, 20);
            this.Mark_t.TabIndex = 11;
            // 
            // Mark_car
            // 
            this.Mark_car.AutoSize = true;
            this.Mark_car.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mark_car.Location = new System.Drawing.Point(141, 9);
            this.Mark_car.Name = "Mark_car";
            this.Mark_car.Size = new System.Drawing.Size(71, 28);
            this.Mark_car.TabIndex = 10;
            this.Mark_car.Text = "Mark";
            // 
            // reset_button
            // 
            this.reset_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_button.Location = new System.Drawing.Point(12, 152);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(103, 23);
            this.reset_button.TabIndex = 18;
            this.reset_button.Text = "Обновить";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // car_info
            // 
            this.car_info.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car_info.Location = new System.Drawing.Point(421, 152);
            this.car_info.Name = "car_info";
            this.car_info.Size = new System.Drawing.Size(103, 23);
            this.car_info.TabIndex = 19;
            this.car_info.Text = "Подробнее";
            this.car_info.UseVisualStyleBackColor = true;
            this.car_info.Click += new System.EventHandler(this.car_info_Click);
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataSource = typeof(EntityFrForm.Cars);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 350);
            this.Controls.Add(this.car_info);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.mileage_t);
            this.Controls.Add(this.Mileage_car);
            this.Controls.Add(this.colour_t);
            this.Controls.Add(this.Colour_car);
            this.Controls.Add(this.year_t);
            this.Controls.Add(this.Year_car);
            this.Controls.Add(this.Mark_t);
            this.Controls.Add(this.Mark_car);
            this.Controls.Add(this.allResButton);
            this.Controls.Add(this.check_change);
            this.Controls.Add(this.check_delete);
            this.Controls.Add(this.check_add);
            this.Controls.Add(this.check_search);
            this.Controls.Add(this.AllCarsTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AllCarsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource carsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView AllCarsTable;
        private System.Windows.Forms.CheckBox check_search;
        private System.Windows.Forms.CheckBox check_add;
        private System.Windows.Forms.CheckBox check_delete;
        private System.Windows.Forms.CheckBox check_change;
        private System.Windows.Forms.Button allResButton;
        private System.Windows.Forms.TextBox mileage_t;
        private System.Windows.Forms.Label Mileage_car;
        private System.Windows.Forms.TextBox colour_t;
        private System.Windows.Forms.Label Colour_car;
        private System.Windows.Forms.TextBox year_t;
        private System.Windows.Forms.Label Year_car;
        private System.Windows.Forms.TextBox Mark_t;
        private System.Windows.Forms.Label Mark_car;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Button car_info;
    }
}

