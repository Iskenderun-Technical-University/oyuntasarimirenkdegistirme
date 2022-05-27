# oyuntasarimirenkdegistirme


proje-onerisi-ymg-oyuntasarimirenkdegistirme created by GitHub Classroom

* Merhaba, ben Olgun Kadir Gülhan  sizlerle Renk değiştirme oyunumu paylaşacağım.

#### Oyun içeriği

* Random hız da  topu  halkaların içerisinden geçirme.  Fakat  oyun da  hayattta kalabilmek için  topun rengindeki  uygun halka parçasından geçmek gerek.

#### Oyun Bilgileri

* Oyun motoru olarak Unity kullanacağız ,  oyun c# dili ile Visual Studio  da yazılacaktır
#### Oyun içi tahmini görseller



![okg2](https://user-images.githubusercontent.com/42507516/170663046-3c085fc0-5f13-480e-90c5-7d624f6e7b3e.png)
Oyunumuz menü sahnesinden başlamaktadır. Yeşil play tuşuna atanan script ile bir sonraki  sahneye geçilip oyun oynanmaktadır. Exit tuşuna basıldığında atanan script ile Application.Exit() fonksiyonu çağrılarak oyundan çıkılmaktadır. “0” yazan text ise oyun oynandığı surece en yüksek puanı yazacaktır. En yüksek puanı yazdırırken PlayerPrefs sınıfından yararlandım. 
![okg1](https://user-images.githubusercontent.com/42507516/170663214-4c66f640-f771-4279-b233-ff7a57a7cc30.png)
Oyunun görseli bu şekildedir. Oyunun amacı topumuzu Space tuşuna basarak yukarıya doğru çıkarıp en yüksek puanı almaktır. Renk topuna çarptığında topun rengi değişmektedir. Burada çarpışma fonksiyonlarından yararlanıldı.Top her uygun renkteki renk tekerinden geçtiğinde skor 50 puan artacaktır. Sağdaki renk topuna atadığım animasyon ile oval ve yukarı aşağı hareketler yapıp görselliği arttırmıştır. Arka plana Particle System den başka bir animasyon kullanarak uzay boşluğu hissi yarattım.

![okg5](https://user-images.githubusercontent.com/42507516/170663312-06f60760-ec36-4425-9056-baa67c1f7cf5.png)

PlayerPrefs ‘ten yararlınarak oyun sonunda kazanılan en yüksek puanı menü’de en yüksek text ‘ine yazdırdım. 
Top nesnesi ekran altına indiğinde ve farklı renkteki renk tekerine çarptığında game over oluyor bu zaman da karşımıza çıkan lose paneli çıkıyor. Lose panelinde olan play tuşuna basarsak oyun tekrar oynanıyor. Exit butonuna basarsak uygulamadan çıkılıyor.
[img1]:https://cdn.kiz10.com/upload/thumbnails/1462480466_color-switch.png
[img2]:https://img.tamindir.com/resize/300x350/ti_e_ul/VolkanYilmazz/p/color-switch_3_507x900.png

#### USE CASE



![usecase](https://user-images.githubusercontent.com/42507516/158465303-84cca853-b99a-4ace-8b8b-506516c47e6f.jpeg)
