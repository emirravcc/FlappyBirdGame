namespace FlappyBirdGamee
{

    public partial class FlappyBirdGamee : Form
    {
        // Oyun Deðiþkenleri
        int boruHizi = 8;     // Borularýn sola akýþ hýzý
        int yerCekimi = 8;    // Kuþun düþüþ hýzý
        int puan = 0;         // Skor
        Random rnd = new Random();
        // Boru yüksekliklerini rastgele yapmak için

        public FlappyBirdGamee()
        {
            InitializeComponent();


            // Klavye tuþlarýný formun algýlamasý için bu ayar zorunludur
            this.KeyPreview = true;
        }

        private void oyunZamani_Tick(object sender, EventArgs e)
        {
            // 1. Hareketler: Kuþ düþer, borular sola kayar
            pbKus.Top += yerCekimi;
            altBoru.Left -= boruHizi;
            ustBoru.Left -= boruHizi;

            // 2. Skoru form baþlýðýnda göster
            this.Text = "Skor: " + puan;

            // 3. Boru Döngüsü: Borular soldan çýkýnca saðdan rastgele gelsin
            if (altBoru.Left < -150)
            {
                puan++;
                altBoru.Left = 600;
                ustBoru.Left = 600;

                // 1. Üst boruyu her zaman TAVANA (0) yapýþtýrýyoruz
                ustBoru.Top = 0;

                // 2. Üst borunun boyunu rastgele deðiþtiriyoruz (DÝNAMÝK BOY)
                // Üst boru en az 150, en fazla 400 boyunda olsun
                int rastgeleBoy = rnd.Next(150, 400);
                ustBoru.Height = rastgeleBoy;

                // 3. Kuþun geçeceði sabit boþluk: 120 birim (Kuþ 50 olduðu için rahat geçer)
                // Alt boru, üst borunun bittiði yerden 120 birim sonra baþlayacak
                altBoru.Top = rastgeleBoy + 150;

                // 4. Alt borunun boyunu, formun sonuna kadar uzatýyoruz
                // Form 700 boyunda, alt boru nerede baþlarsa baþlasýn 700'e kadar uzansýn
                altBoru.Height = 700 - altBoru.Top;
            }
            // 4. Çarpýþma Kontrolü (Boruya, zemine veya tavanýn dýþýna çarpma)
            if (pbKus.Bounds.IntersectsWith(altBoru.Bounds) ||
                    pbKus.Bounds.IntersectsWith(ustBoru.Bounds) ||
                    pbKus.Bounds.IntersectsWith(pbZemin.Bounds) ||
                    pbKus.Top < -50)
            {
                OyunBitti();
            }
        }

        private void FlappyBirdGamee_KeyDown(object sender, KeyEventArgs e)
        {
            // Boþluk (Space) tuþuna basýnca yerçekimini tersine çevir (Zýpla)
            if (e.KeyCode == Keys.Space)
            {
                yerCekimi = -12;
            }
        }

        private void FlappyBirdGamee_KeyUp(object sender, KeyEventArgs e)
        {
            // Boþluk tuþu býrakýlýnca normal yerçekimine dön (Düþ)
            if (e.KeyCode == Keys.Space)
            {
                yerCekimi = 8;
            }
        }

        private void OyunBitti()
        {
            // Zamanlayýcýyý durdur ve mesaj ver
            oyunZamani.Stop();
            MessageBox.Show("Oyun Bitti! Toplam Puanýn: " + puan);

            // Eðer istersen oyunu otomatik yeniden baþlatmak için þu satýrý ekleyebilirsin:
            // Application.Restart();
        }

        private void ustBoru_Click(object sender, EventArgs e)
        {

        }

        private void pbZemin_Click(object sender, EventArgs e)
        {

        }

        private void pbKus_Click(object sender, EventArgs e)
        {

        }

        private void altBoru_Click(object sender, EventArgs e)
        {

        }
    }
}
