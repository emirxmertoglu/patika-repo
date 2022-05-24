# [Patika.dev](https://www.patika.dev/tr) Veri Yapıları ve Algoritmalar Kursu

## Merge Sort Projesi

[16, 21, 11, 8, 12, 22] dizisinin Merge Sort'a göre adımları;

- Öncelikle diziyi tek eleman kalıncaya kadar ikili parçalara ayıracağız.
  - [16, 21, 11] --- [8, 12, 22]
  - [16] --- [21, 11] --- [8] --- [12, 22]
  - [16] --- [21] +++ [11] --- [8] --- [12] +++ [22]
- Şimdi birleştirme işlemine sayısal değeri küçük olan elemanla başlayacağız;
  - [16] --- [11, 21] --- [8] --- [12, 22]
  - [11, 16, 21] --- [8, 12, 22]
  - [8, 11, 12, 16, 21, 22]

Big O gösterimi;

- Diziyi parçalara ayırırken sürekli 2'ye böldüğümüz için; 2^x = n => logn,
- Birleştirme yaparken ise elemanların birbirlerine göre karşılaştırmasını yapmanın maliyeti n - 1 => n,
- Bütun bu işlemlerin maliyeti: O(n \* logn)
