# [Patika.dev](https://www.patika.dev/tr) Veri Yapıları ve Algoritmalar Kursu

## Binary Search Tree Projesi

1-) [7, 5, 1, 8, 3, 6, 0, 9, 4, 2] dizisinin Binary Search Tree'ye göre adımları;

- [7, 5, 1, 8, 3, 6, 0, 9, 4, 2] dizisinin root elemanı 6 sayısı olsun,

- Dizinin ilk elemanı olan 7'nin sayısal değeri 6'dan büyük olduğu için, 6'nın sağ düğümüne geçecek.

  ```
   6
       \
           7
  ```

- Dizinin ikinci elemanı olan 5, root elemanımız olan 6'dan küçük olduğu için, 6'nın sol düğümüne geçecek.

  ```
          6
      /       \
  5               7
  ```

- Dizinin üçüncü elemanı olan 1, root elemanımız olan 6'dan küçük olduğu için, 6'nın sol düğümüne geçecek. Sol düğümdeki 5 ile karşılaştırılıp, 5'ten küçük olduğu 5'in sol düğümünde kendine yer alacak.

  ```
                  6
              /       \
          5               7
      /
  1
  ```

- Dizinin dördüncü elemanı olan 8, root elemanımız olan 6'dan büyük olduğu için, 6'nın sağ düğümüne geçecek. Sağ düğümdeki 7 ile karşılaştırılıp, 7'den büyük olduğu için 7'nin sağ düğümünde kendine yer alacak.

  ```
                  6
              /       \
          5               7
      /                       \
  1                               8
  ```

- Dizinin beşinci elemanı olan 3, root elemanımız olan 6'dan küçük olduğu için, 6'nın sol düğümüne geçecek. Sol düğümdeki 5 ile karşılaştırılıp, 5'ten küçük olduğu için 5'in sol düğümüne geçecek. Sol düğümdeki 1 ile karşılaştırılıp, 1'den büyük olduğu için 1'in sağ düğümünde kendine yer alacak.

  ```
                  6
              /       \
          5               7
      /                       \
  1                               8
      \
          3
  ```

- Dizinin 6. elemanı olan 6 sayısını zaten root olarak seçtiğimiz için atlıyoruz.

- Dizinin yedinci elemanı olan 9, root elemanımız olan 6'dan büyük olduğu için, 6'nın sağ düğümüne geçecek. Sağ düğümdeki 7 ile karşılaştırılıp, 7'den büyük olduğu için 7'nin sağ düğümüne geçecek. Sağ düğümdeki 8 ile karşılaştırılıp, 8'den büyük olduğu için 8'in sağ düğümünde kendine yer alacak.

  ```
                  6
              /       \
          5               7
      /                       \
  1                               8
      \                               \
          3                               9
  ```

- Dizinin sekizinci elemanı olan 4, root elemanımız olan 6'dan küçük olduğu için, 6'nın sol düğümüne geçecek. Sol düğümdeki 5 ile karşılaştırılıp, 5'ten küçük olduğu için 5'in sol düğümüne geçecek. Sol düğümdeki 1 ile karşılaştırılıp, 1'den büyük olduğu için 1'in sağ düğümüne geçecek. Sağ düğümdeki 3 ile karşılaştırılıp, 3'den büyük olduğu için 3'ün sağ düğümünde kendine yer alacak.

  ```
                  6
              /       \
          5               7
      /                       \
  1                               8
      \                               \
          3                               9
              \
                  4
  ```

- Dizinin dokuzuncu elemanı olan 2, root elemanımız olan 6'dan küçük olduğu için, 6'nın sol düğümüne geçecek. Sol düğümdeki 5 ile karşılaştırılıp, 5'ten küçük olduğu için 5'in sol düğümüne geçecek. Sol düğümdeki 1 ile karşılaştırılıp, 1'den büyük olduğu için 1'in sağ düğümüne geçecek. Sağ düğümdeki 3 ile karşılaştırılıp, 3'den küçük olduğu için 3'ün sol düğümünde kendine yer alacak.
  ```
                  6
              /       \
          5               7
      /                       \
  1                               8
      \                               \
          3                               9
      /       \
  2              4
  ```
