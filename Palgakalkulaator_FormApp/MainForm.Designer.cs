namespace Palgakalkulaator_FormApp
{
partial class MainForm
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
        this.cb_MaksuvabaTulu = new System.Windows.Forms.CheckBox();
        this.cb_Töötuskindlustusmakse_Tööandja = new System.Windows.Forms.CheckBox();
        this.cb_Töötuskindlustusmakse_Töötaja = new System.Windows.Forms.CheckBox();
        this.cb_Kogusmispension = new System.Windows.Forms.CheckBox();
        this.lbl_Tulemus = new System.Windows.Forms.Label();
        this.lbl_KuluKokku = new System.Windows.Forms.Label();
        this.lbl_Sotsiaalmaks = new System.Windows.Forms.Label();
        this.lbl_Töötuskindlustusmakse_Tööandja = new System.Windows.Forms.Label();
        this.lbl_Brutopalk_2 = new System.Windows.Forms.Label();
        this.lbl_Kogusmispension = new System.Windows.Forms.Label();
        this.lbl_Töötuskindlustusmakse_Töötaja = new System.Windows.Forms.Label();
        this.lbl_Tulumaks = new System.Windows.Forms.Label();
        this.lbl_Netopalk = new System.Windows.Forms.Label();
        this.lbl_EUR = new System.Windows.Forms.Label();
        this.lbl_KuluKokkuArv = new System.Windows.Forms.Label();
        this.lbl_SotsiaalmaksArv = new System.Windows.Forms.Label();
        this.lbl_Töötuskindlustusmakse_TööandjaArv = new System.Windows.Forms.Label();
        this.lbl_Brutopalk_2Arv = new System.Windows.Forms.Label();
        this.lbl_KogusmispensionArv = new System.Windows.Forms.Label();
        this.lbl_Töötuskindlustusmakse_TöötajaArv = new System.Windows.Forms.Label();
        this.lbl_TulumaksArv = new System.Windows.Forms.Label();
        this.lbl_NetopalkArv = new System.Windows.Forms.Label();
        this.lbl_Brutopalk = new System.Windows.Forms.Label();
        this.tb_Brutopalk = new System.Windows.Forms.TextBox();
        this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        this.menüüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.väljuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.abiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.programmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.menuStrip1.SuspendLayout();
        this.SuspendLayout();
        //
        // cb_MaksuvabaTulu
        //
        this.cb_MaksuvabaTulu.AutoSize = true;
        this.cb_MaksuvabaTulu.Checked = true;
        this.cb_MaksuvabaTulu.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cb_MaksuvabaTulu.Location = new System.Drawing.Point(554, 29);
        this.cb_MaksuvabaTulu.Name = "cb_MaksuvabaTulu";
        this.cb_MaksuvabaTulu.Size = new System.Drawing.Size(219, 17);
        this.cb_MaksuvabaTulu.TabIndex = 0;
        this.cb_MaksuvabaTulu.Text = "Arvesta maksuvaba tulu (180 EUR kuus)";
        this.cb_MaksuvabaTulu.UseVisualStyleBackColor = true;
        //
        // cb_Töötuskindlustusmakse_Tööandja
        //
        this.cb_Töötuskindlustusmakse_Tööandja.AutoSize = true;
        this.cb_Töötuskindlustusmakse_Tööandja.Checked = true;
        this.cb_Töötuskindlustusmakse_Tööandja.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cb_Töötuskindlustusmakse_Tööandja.Location = new System.Drawing.Point(554, 66);
        this.cb_Töötuskindlustusmakse_Tööandja.Name = "cb_Töötuskindlustusmakse_Tööandja";
        this.cb_Töötuskindlustusmakse_Tööandja.Size = new System.Drawing.Size(213, 17);
        this.cb_Töötuskindlustusmakse_Tööandja.TabIndex = 1;
        this.cb_Töötuskindlustusmakse_Tööandja.Text = "Tööandja töötuskindlustusmakse (0.8%)";
        this.cb_Töötuskindlustusmakse_Tööandja.UseVisualStyleBackColor = true;
        //
        // cb_Töötuskindlustusmakse_Töötaja
        //
        this.cb_Töötuskindlustusmakse_Töötaja.AutoSize = true;
        this.cb_Töötuskindlustusmakse_Töötaja.Checked = true;
        this.cb_Töötuskindlustusmakse_Töötaja.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cb_Töötuskindlustusmakse_Töötaja.Location = new System.Drawing.Point(554, 103);
        this.cb_Töötuskindlustusmakse_Töötaja.Name = "cb_Töötuskindlustusmakse_Töötaja";
        this.cb_Töötuskindlustusmakse_Töötaja.Size = new System.Drawing.Size(261, 17);
        this.cb_Töötuskindlustusmakse_Töötaja.TabIndex = 2;
        this.cb_Töötuskindlustusmakse_Töötaja.Text = "Töötaja (kindlustatu) töötuskindlustusmakse(1.6%)";
        this.cb_Töötuskindlustusmakse_Töötaja.UseVisualStyleBackColor = true;
        //
        // cb_Kogusmispension
        //
        this.cb_Kogusmispension.AutoSize = true;
        this.cb_Kogusmispension.Checked = true;
        this.cb_Kogusmispension.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cb_Kogusmispension.Location = new System.Drawing.Point(554, 140);
        this.cb_Kogusmispension.Name = "cb_Kogusmispension";
        this.cb_Kogusmispension.Size = new System.Drawing.Size(159, 17);
        this.cb_Kogusmispension.TabIndex = 3;
        this.cb_Kogusmispension.Text = "Kogumispension (II sammas)";
        this.cb_Kogusmispension.UseVisualStyleBackColor = true;
        //
        // lbl_Tulemus
        //
        this.lbl_Tulemus.AutoSize = true;
        this.lbl_Tulemus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.lbl_Tulemus.Location = new System.Drawing.Point(42, 154);
        this.lbl_Tulemus.Name = "lbl_Tulemus";
        this.lbl_Tulemus.Size = new System.Drawing.Size(84, 24);
        this.lbl_Tulemus.TabIndex = 4;
        this.lbl_Tulemus.Text = "Tulemus";
        //
        // lbl_KuluKokku
        //
        this.lbl_KuluKokku.AutoSize = true;
        this.lbl_KuluKokku.Location = new System.Drawing.Point(43, 193);
        this.lbl_KuluKokku.Name = "lbl_KuluKokku";
        this.lbl_KuluKokku.Size = new System.Drawing.Size(167, 13);
        this.lbl_KuluKokku.TabIndex = 5;
        this.lbl_KuluKokku.Text = "Tööandja kulu kokku (palgafond):";
        //
        // lbl_Sotsiaalmaks
        //
        this.lbl_Sotsiaalmaks.AutoSize = true;
        this.lbl_Sotsiaalmaks.Location = new System.Drawing.Point(43, 231);
        this.lbl_Sotsiaalmaks.Name = "lbl_Sotsiaalmaks";
        this.lbl_Sotsiaalmaks.Size = new System.Drawing.Size(72, 13);
        this.lbl_Sotsiaalmaks.TabIndex = 6;
        this.lbl_Sotsiaalmaks.Text = "Sotsiaalmaks:";
        //
        // lbl_Töötuskindlustusmakse_Tööandja
        //
        this.lbl_Töötuskindlustusmakse_Tööandja.AutoSize = true;
        this.lbl_Töötuskindlustusmakse_Tööandja.Location = new System.Drawing.Point(43, 269);
        this.lbl_Töötuskindlustusmakse_Tööandja.Name = "lbl_Töötuskindlustusmakse_Tööandja";
        this.lbl_Töötuskindlustusmakse_Tööandja.Size = new System.Drawing.Size(171, 13);
        this.lbl_Töötuskindlustusmakse_Tööandja.TabIndex = 7;
        this.lbl_Töötuskindlustusmakse_Tööandja.Text = "Töötuskindlustusmakse (tööandja):";
        //
        // lbl_Brutopalk_2
        //
        this.lbl_Brutopalk_2.AutoSize = true;
        this.lbl_Brutopalk_2.Location = new System.Drawing.Point(43, 307);
        this.lbl_Brutopalk_2.Name = "lbl_Brutopalk_2";
        this.lbl_Brutopalk_2.Size = new System.Drawing.Size(55, 13);
        this.lbl_Brutopalk_2.TabIndex = 8;
        this.lbl_Brutopalk_2.Text = "Brutopalk:";
        //
        // lbl_Kogusmispension
        //
        this.lbl_Kogusmispension.AutoSize = true;
        this.lbl_Kogusmispension.Location = new System.Drawing.Point(43, 345);
        this.lbl_Kogusmispension.Name = "lbl_Kogusmispension";
        this.lbl_Kogusmispension.Size = new System.Drawing.Size(148, 13);
        this.lbl_Kogusmispension.TabIndex = 9;
        this.lbl_Kogusmispension.Text = "Kogusmispension (II sammas):";
        //
        // lbl_Töötuskindlustusmakse_Töötaja
        //
        this.lbl_Töötuskindlustusmakse_Töötaja.AutoSize = true;
        this.lbl_Töötuskindlustusmakse_Töötaja.Location = new System.Drawing.Point(43, 383);
        this.lbl_Töötuskindlustusmakse_Töötaja.Name = "lbl_Töötuskindlustusmakse_Töötaja";
        this.lbl_Töötuskindlustusmakse_Töötaja.Size = new System.Drawing.Size(162, 13);
        this.lbl_Töötuskindlustusmakse_Töötaja.TabIndex = 10;
        this.lbl_Töötuskindlustusmakse_Töötaja.Text = "Töötuskindlustusmakse (töötaja):";
        //
        // lbl_Tulumaks
        //
        this.lbl_Tulumaks.AutoSize = true;
        this.lbl_Tulumaks.Location = new System.Drawing.Point(43, 421);
        this.lbl_Tulumaks.Name = "lbl_Tulumaks";
        this.lbl_Tulumaks.Size = new System.Drawing.Size(56, 13);
        this.lbl_Tulumaks.TabIndex = 11;
        this.lbl_Tulumaks.Text = "Tulumaks:";
        //
        // lbl_Netopalk
        //
        this.lbl_Netopalk.AutoSize = true;
        this.lbl_Netopalk.Location = new System.Drawing.Point(43, 459);
        this.lbl_Netopalk.Name = "lbl_Netopalk";
        this.lbl_Netopalk.Size = new System.Drawing.Size(53, 13);
        this.lbl_Netopalk.TabIndex = 12;
        this.lbl_Netopalk.Text = "Netopalk:";
        //
        // lbl_EUR
        //
        this.lbl_EUR.AutoSize = true;
        this.lbl_EUR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.lbl_EUR.Location = new System.Drawing.Point(246, 154);
        this.lbl_EUR.Name = "lbl_EUR";
        this.lbl_EUR.Size = new System.Drawing.Size(49, 24);
        this.lbl_EUR.TabIndex = 13;
        this.lbl_EUR.Text = "EUR";
        //
        // lbl_KuluKokkuArv
        //
        this.lbl_KuluKokkuArv.AutoSize = true;
        this.lbl_KuluKokkuArv.Location = new System.Drawing.Point(247, 193);
        this.lbl_KuluKokkuArv.Name = "lbl_KuluKokkuArv";
        this.lbl_KuluKokkuArv.Size = new System.Drawing.Size(13, 13);
        this.lbl_KuluKokkuArv.TabIndex = 14;
        this.lbl_KuluKokkuArv.Text = "0";
        //
        // lbl_SotsiaalmaksArv
        //
        this.lbl_SotsiaalmaksArv.AutoSize = true;
        this.lbl_SotsiaalmaksArv.Location = new System.Drawing.Point(247, 231);
        this.lbl_SotsiaalmaksArv.Name = "lbl_SotsiaalmaksArv";
        this.lbl_SotsiaalmaksArv.Size = new System.Drawing.Size(13, 13);
        this.lbl_SotsiaalmaksArv.TabIndex = 15;
        this.lbl_SotsiaalmaksArv.Text = "0";
        //
        // lbl_Töötuskindlustusmakse_TööandjaArv
        //
        this.lbl_Töötuskindlustusmakse_TööandjaArv.AutoSize = true;
        this.lbl_Töötuskindlustusmakse_TööandjaArv.Location = new System.Drawing.Point(247, 269);
        this.lbl_Töötuskindlustusmakse_TööandjaArv.Name = "lbl_Töötuskindlustusmakse_TööandjaArv";
        this.lbl_Töötuskindlustusmakse_TööandjaArv.Size = new System.Drawing.Size(13, 13);
        this.lbl_Töötuskindlustusmakse_TööandjaArv.TabIndex = 16;
        this.lbl_Töötuskindlustusmakse_TööandjaArv.Text = "0";
        //
        // lbl_Brutopalk_2Arv
        //
        this.lbl_Brutopalk_2Arv.AutoSize = true;
        this.lbl_Brutopalk_2Arv.Location = new System.Drawing.Point(247, 307);
        this.lbl_Brutopalk_2Arv.Name = "lbl_Brutopalk_2Arv";
        this.lbl_Brutopalk_2Arv.Size = new System.Drawing.Size(13, 13);
        this.lbl_Brutopalk_2Arv.TabIndex = 17;
        this.lbl_Brutopalk_2Arv.Text = "0";
        //
        // lbl_KogusmispensionArv
        //
        this.lbl_KogusmispensionArv.AutoSize = true;
        this.lbl_KogusmispensionArv.Location = new System.Drawing.Point(247, 345);
        this.lbl_KogusmispensionArv.Name = "lbl_KogusmispensionArv";
        this.lbl_KogusmispensionArv.Size = new System.Drawing.Size(13, 13);
        this.lbl_KogusmispensionArv.TabIndex = 18;
        this.lbl_KogusmispensionArv.Text = "0";
        //
        // lbl_Töötuskindlustusmakse_TöötajaArv
        //
        this.lbl_Töötuskindlustusmakse_TöötajaArv.AutoSize = true;
        this.lbl_Töötuskindlustusmakse_TöötajaArv.Location = new System.Drawing.Point(247, 383);
        this.lbl_Töötuskindlustusmakse_TöötajaArv.Name = "lbl_Töötuskindlustusmakse_TöötajaArv";
        this.lbl_Töötuskindlustusmakse_TöötajaArv.Size = new System.Drawing.Size(13, 13);
        this.lbl_Töötuskindlustusmakse_TöötajaArv.TabIndex = 19;
        this.lbl_Töötuskindlustusmakse_TöötajaArv.Text = "0";
        //
        // lbl_TulumaksArv
        //
        this.lbl_TulumaksArv.AutoSize = true;
        this.lbl_TulumaksArv.Location = new System.Drawing.Point(247, 421);
        this.lbl_TulumaksArv.Name = "lbl_TulumaksArv";
        this.lbl_TulumaksArv.Size = new System.Drawing.Size(13, 13);
        this.lbl_TulumaksArv.TabIndex = 20;
        this.lbl_TulumaksArv.Text = "0";
        //
        // lbl_NetopalkArv
        //
        this.lbl_NetopalkArv.AutoSize = true;
        this.lbl_NetopalkArv.Location = new System.Drawing.Point(247, 459);
        this.lbl_NetopalkArv.Name = "lbl_NetopalkArv";
        this.lbl_NetopalkArv.Size = new System.Drawing.Size(13, 13);
        this.lbl_NetopalkArv.TabIndex = 21;
        this.lbl_NetopalkArv.Text = "0";
        //
        // lbl_Brutopalk
        //
        this.lbl_Brutopalk.AutoSize = true;
        this.lbl_Brutopalk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.lbl_Brutopalk.Location = new System.Drawing.Point(42, 62);
        this.lbl_Brutopalk.Name = "lbl_Brutopalk";
        this.lbl_Brutopalk.Size = new System.Drawing.Size(81, 20);
        this.lbl_Brutopalk.TabIndex = 22;
        this.lbl_Brutopalk.Text = "Brutopalk:";
        //
        // tb_Brutopalk
        //
        this.tb_Brutopalk.Location = new System.Drawing.Point(129, 63);
        this.tb_Brutopalk.Name = "tb_Brutopalk";
        this.tb_Brutopalk.Size = new System.Drawing.Size(100, 20);
        this.tb_Brutopalk.TabIndex = 23;
        //
        // menuStrip1
        //
        this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            this.menüüToolStripMenuItem,
            this.abiToolStripMenuItem
        });
        this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.Size = new System.Drawing.Size(832, 24);
        this.menuStrip1.TabIndex = 24;
        this.menuStrip1.Text = "menuStrip1";
        //
        // menüüToolStripMenuItem
        //
        this.menüüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            this.väljuToolStripMenuItem
        });
        this.menüüToolStripMenuItem.Name = "menüüToolStripMenuItem";
        this.menüüToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
        this.menüüToolStripMenuItem.Text = "Menüü";
        //
        // väljuToolStripMenuItem
        //
        this.väljuToolStripMenuItem.Name = "väljuToolStripMenuItem";
        this.väljuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        this.väljuToolStripMenuItem.Text = "Välju";
        //
        // abiToolStripMenuItem
        //
        this.abiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            this.programmToolStripMenuItem
        });
        this.abiToolStripMenuItem.Name = "abiToolStripMenuItem";
        this.abiToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
        this.abiToolStripMenuItem.Text = "Abi";
        //
        // programmToolStripMenuItem
        //
        this.programmToolStripMenuItem.Name = "programmToolStripMenuItem";
        this.programmToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        this.programmToolStripMenuItem.Text = "Programm";
        //
        // MainForm
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.AutoSize = true;
        this.ClientSize = new System.Drawing.Size(832, 565);
        this.Controls.Add(this.tb_Brutopalk);
        this.Controls.Add(this.lbl_Brutopalk);
        this.Controls.Add(this.lbl_NetopalkArv);
        this.Controls.Add(this.lbl_TulumaksArv);
        this.Controls.Add(this.lbl_Töötuskindlustusmakse_TöötajaArv);
        this.Controls.Add(this.lbl_KogusmispensionArv);
        this.Controls.Add(this.lbl_Brutopalk_2Arv);
        this.Controls.Add(this.lbl_Töötuskindlustusmakse_TööandjaArv);
        this.Controls.Add(this.lbl_SotsiaalmaksArv);
        this.Controls.Add(this.lbl_KuluKokkuArv);
        this.Controls.Add(this.lbl_EUR);
        this.Controls.Add(this.lbl_Netopalk);
        this.Controls.Add(this.lbl_Tulumaks);
        this.Controls.Add(this.lbl_Töötuskindlustusmakse_Töötaja);
        this.Controls.Add(this.lbl_Kogusmispension);
        this.Controls.Add(this.lbl_Brutopalk_2);
        this.Controls.Add(this.lbl_Töötuskindlustusmakse_Tööandja);
        this.Controls.Add(this.lbl_Sotsiaalmaks);
        this.Controls.Add(this.lbl_KuluKokku);
        this.Controls.Add(this.lbl_Tulemus);
        this.Controls.Add(this.cb_Kogusmispension);
        this.Controls.Add(this.cb_Töötuskindlustusmakse_Töötaja);
        this.Controls.Add(this.cb_Töötuskindlustusmakse_Tööandja);
        this.Controls.Add(this.cb_MaksuvabaTulu);
        this.Controls.Add(this.menuStrip1);
        this.MainMenuStrip = this.menuStrip1;
        this.Name = "MainForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Palgakalkulaator";
        this.menuStrip1.ResumeLayout(false);
        this.menuStrip1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.CheckBox cb_MaksuvabaTulu;
    private System.Windows.Forms.CheckBox cb_Töötuskindlustusmakse_Tööandja;
    private System.Windows.Forms.CheckBox cb_Töötuskindlustusmakse_Töötaja;
    private System.Windows.Forms.CheckBox cb_Kogusmispension;
    private System.Windows.Forms.Label lbl_Tulemus;
    private System.Windows.Forms.Label lbl_KuluKokku;
    private System.Windows.Forms.Label lbl_Sotsiaalmaks;
    private System.Windows.Forms.Label lbl_Töötuskindlustusmakse_Tööandja;
    private System.Windows.Forms.Label lbl_Brutopalk_2;
    private System.Windows.Forms.Label lbl_Kogusmispension;
    private System.Windows.Forms.Label lbl_Töötuskindlustusmakse_Töötaja;
    private System.Windows.Forms.Label lbl_Tulumaks;
    private System.Windows.Forms.Label lbl_Netopalk;
    private System.Windows.Forms.Label lbl_EUR;
    private System.Windows.Forms.Label lbl_KuluKokkuArv;
    private System.Windows.Forms.Label lbl_SotsiaalmaksArv;
    private System.Windows.Forms.Label lbl_Töötuskindlustusmakse_TööandjaArv;
    private System.Windows.Forms.Label lbl_Brutopalk_2Arv;
    private System.Windows.Forms.Label lbl_KogusmispensionArv;
    private System.Windows.Forms.Label lbl_Töötuskindlustusmakse_TöötajaArv;
    private System.Windows.Forms.Label lbl_TulumaksArv;
    private System.Windows.Forms.Label lbl_NetopalkArv;
    private System.Windows.Forms.Label lbl_Brutopalk;
    private System.Windows.Forms.TextBox tb_Brutopalk;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem menüüToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem väljuToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem abiToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem programmToolStripMenuItem;
}
}

