# 🚀 Basit Web Tarayıcı (Simple Web Browser)

Bu proje, C# ve Windows Forms kullanılarak geliştirilmiş basit bir web tarayıcı uygulamasıdır. Kullanıcıların web sayfalarında gezinmesine, önceki/sonraki sayfalara gitmesine, sayfa yüklemesini durdurmasına ve mevcut sayfanın URL'si ile HTML içeriğini görüntülemesine olanak tanır.

## 🎯 Projenin Amacı

Bu uygulama, Windows Forms'daki `WebBrowser` kontrolünün temel özelliklerini ve olay yönetimini göstermek amacıyla oluşturulmuştur. Basit bir arayüzle temel web gezinme işlevlerini sunar.

## ⚙️ Kurulum ve Çalıştırma

1.  **Repoyu Klonlama:**
    *   Bu repoyu yerel makinenize klonlayın:
        ```bash
        git clone https://github.com/KeremOgzhn/webBrowser.git
        ```
    *   Proje dizinine gidin:
        ```bash
        cd webBrowser
        ```

2.  **Projeyi Açma ve Çalıştırma:**
    *   Proje klasöründe bulunan `.sln` (Solution) dosyasını (muhtemelen `hafta5_webBrowser.sln` veya benzeri bir isimde olacaktır) Visual Studio ile açın.
    *   Visual Studio'da projeyi derleyin (Build > Build Solution).
    *   Projeyi çalıştırın (Debug > Start Debugging veya F5 tuşu).

    *Not: Bu proje standart .NET kütüphanelerini kullandığı için ek bir kurulum veya bağımlılık yönetimi gerektirmez.*

## 🛠️ Kullanım

Uygulama başlatıldığında, aşağıdaki kontrolleri içeren bir ana form açılır:

*   **Adres Çubuğu (`TextBox`):** Gitmek istediğiniz web sayfasının URL'sini buraya yazabilirsiniz.
*   **Git Butonu:** Adres çubuğuna yazılan URL'ye gider.
*   **Geri Butonu:** Tarayıcı geçmişindeki bir önceki sayfaya döner.
*   **İleri Butonu:** Tarayıcı geçmişindeki bir sonraki sayfaya ilerler.
*   **Dur Butonu:** Mevcut sayfanın yüklenmesini durdurur.
*   **Web Sayfası Alanı (`WebBrowser` kontrolü):** Web sayfalarının görüntülendiği ana alandır.
*   **HTML İçerik Alanı (`RichTextBox`):** Yüklenen sayfanın HTML kaynak kodunu gösterir.

**Temel İşlevler:**

1.  **Web Sayfasına Gitme:**
    *   Üstteki adres çubuğuna (`textBox1`) gitmek istediğiniz web sitesinin tam URL'sini (örn: `https://www.google.com`) yazın.
    *   `Git` butonuna tıklayın veya adres çubuğundayken `Enter` tuşuna basın.
    *   Belirtilen web sayfası ana alanda (`webBrowser2`) yüklenecektir.
    *   Sayfa yüklendikten sonra, sayfanın URL'si otomatik olarak adres çubuğunda güncellenir ve sayfanın HTML kaynak kodu aşağıdaki `richTextBox1` alanında gösterilir.

2.  **Geri Gitme:**
    *   Daha önce ziyaret ettiğiniz bir sayfaya dönmek için `Geri` butonuna tıklayın.

3.  **İleri Gitme:**
    *   Geri gittikten sonra, daha sonra ziyaret ettiğiniz bir sayfaya tekrar ilerlemek için `İleri` butonuna tıklayın.

4.  **Sayfa Yüklemesini Durdurma:**
    *   Bir sayfa yüklenirken yükleme işlemini iptal etmek için `Dur` butonuna tıklayın.

5.  **URL ve HTML Görüntüleme:**
    *   Bir web sayfası başarıyla yüklendiğinde, sayfanın tam URL'si adres çubuğunda (`textBox1`) otomatik olarak güncellenir.
    *   Aynı zamanda, yüklenen sayfanın ham HTML içeriği formun alt kısmındaki metin alanında (`richTextBox1`) görüntülenir.

    *Not: Uygulama, `webBrowser2.ScriptErrorsSuppressed = true;` ayarı sayesinde web sayfalarındaki olası script hatalarının kullanıcıya gösterilmesini engeller.*
