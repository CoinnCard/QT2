namespace QT2_SE
{
    partial class Ticket
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
            this.Ticket_Product = new System.Windows.Forms.Label();
            this.lb_Destination = new System.Windows.Forms.Label();
            this.cmb_Destination = new System.Windows.Forms.ComboBox();
            this.lb_Transport = new System.Windows.Forms.Label();
            this.lb_Payment = new System.Windows.Forms.Label();
            this.cmb_Transport = new System.Windows.Forms.ComboBox();
            this.cmb_Payment = new System.Windows.Forms.ComboBox();
            this.bt_proceed = new System.Windows.Forms.Button();
            this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.txtTicketInfo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // Ticket_Product
            // 
            this.Ticket_Product.AutoSize = true;
            this.Ticket_Product.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Ticket_Product.Location = new System.Drawing.Point(428, 30);
            this.Ticket_Product.Name = "Ticket_Product";
            this.Ticket_Product.Size = new System.Drawing.Size(131, 22);
            this.Ticket_Product.TabIndex = 0;
            this.Ticket_Product.Text = "Ticket Machine";
            this.Ticket_Product.Click += new System.EventHandler(this.Ticket_Bus_Click);
            // 
            // lb_Destination
            // 
            this.lb_Destination.AutoSize = true;
            this.lb_Destination.Location = new System.Drawing.Point(80, 86);
            this.lb_Destination.Name = "lb_Destination";
            this.lb_Destination.Size = new System.Drawing.Size(157, 20);
            this.lb_Destination.TabIndex = 1;
            this.lb_Destination.Text = "Select Destination";
            // 
            // cmb_Destination
            // 
            this.cmb_Destination.FormattingEnabled = true;
            this.cmb_Destination.Location = new System.Drawing.Point(327, 85);
            this.cmb_Destination.Name = "cmb_Destination";
            this.cmb_Destination.Size = new System.Drawing.Size(157, 28);
            this.cmb_Destination.TabIndex = 2;
            this.cmb_Destination.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lb_Transport
            // 
            this.lb_Transport.AutoSize = true;
            this.lb_Transport.Location = new System.Drawing.Point(80, 143);
            this.lb_Transport.Name = "lb_Transport";
            this.lb_Transport.Size = new System.Drawing.Size(182, 20);
            this.lb_Transport.TabIndex = 3;
            this.lb_Transport.Text = "Select Transportation";
            // 
            // lb_Payment
            // 
            this.lb_Payment.AutoSize = true;
            this.lb_Payment.Location = new System.Drawing.Point(80, 197);
            this.lb_Payment.Name = "lb_Payment";
            this.lb_Payment.Size = new System.Drawing.Size(199, 20);
            this.lb_Payment.TabIndex = 4;
            this.lb_Payment.Text = "Select Payment Method";
            this.lb_Payment.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmb_Transport
            // 
            this.cmb_Transport.FormattingEnabled = true;
            this.cmb_Transport.Location = new System.Drawing.Point(327, 143);
            this.cmb_Transport.Name = "cmb_Transport";
            this.cmb_Transport.Size = new System.Drawing.Size(157, 28);
            this.cmb_Transport.TabIndex = 5;
            this.cmb_Transport.SelectedIndexChanged += new System.EventHandler(this.cmb_Transport_SelectedIndexChanged);
            // 
            // cmb_Payment
            // 
            this.cmb_Payment.FormattingEnabled = true;
            this.cmb_Payment.Location = new System.Drawing.Point(327, 194);
            this.cmb_Payment.Name = "cmb_Payment";
            this.cmb_Payment.Size = new System.Drawing.Size(157, 28);
            this.cmb_Payment.TabIndex = 6;
            this.cmb_Payment.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // bt_proceed
            // 
            this.bt_proceed.Location = new System.Drawing.Point(318, 268);
            this.bt_proceed.Name = "bt_proceed";
            this.bt_proceed.Size = new System.Drawing.Size(187, 40);
            this.bt_proceed.TabIndex = 7;
            this.bt_proceed.Text = "proceed to payment";
            this.bt_proceed.UseVisualStyleBackColor = true;
            this.bt_proceed.Click += new System.EventHandler(this.bt_proceed_Click);
            // 
            // dataGridViewTickets
            // 
            this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTickets.Location = new System.Drawing.Point(23, 405);
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewTickets.RowHeadersWidth = 82;
            this.dataGridViewTickets.RowTemplate.Height = 33;
            this.dataGridViewTickets.Size = new System.Drawing.Size(1013, 240);
            this.dataGridViewTickets.TabIndex = 8;
            this.dataGridViewTickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTickets_CellContentClick);
            // 
            // txtTicketInfo
            // 
            this.txtTicketInfo.Location = new System.Drawing.Point(23, 363);
            this.txtTicketInfo.Name = "txtTicketInfo";
            this.txtTicketInfo.Size = new System.Drawing.Size(179, 26);
            this.txtTicketInfo.TabIndex = 9;
            this.txtTicketInfo.Text = "Displays Ticket Info";
            this.txtTicketInfo.TextChanged += new System.EventHandler(this.txtTicketInfo_TextChanged);
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1047, 672);
            this.Controls.Add(this.txtTicketInfo);
            this.Controls.Add(this.dataGridViewTickets);
            this.Controls.Add(this.bt_proceed);
            this.Controls.Add(this.cmb_Payment);
            this.Controls.Add(this.cmb_Transport);
            this.Controls.Add(this.lb_Payment);
            this.Controls.Add(this.lb_Transport);
            this.Controls.Add(this.cmb_Destination);
            this.Controls.Add(this.lb_Destination);
            this.Controls.Add(this.Ticket_Product);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Ticket";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ticket_Product;
        private System.Windows.Forms.Label lb_Destination;
        private System.Windows.Forms.ComboBox cmb_Destination;
        private System.Windows.Forms.Label lb_Transport;
        private System.Windows.Forms.Label lb_Payment;
        private System.Windows.Forms.ComboBox cmb_Transport;
        private System.Windows.Forms.ComboBox cmb_Payment;
        private System.Windows.Forms.Button bt_proceed;
        private System.Windows.Forms.DataGridView dataGridViewTickets;
        private System.Windows.Forms.TextBox txtTicketInfo;
    }
}

