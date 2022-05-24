# [Patika.dev](https://www.patika.dev/tr) Veri Yapıları ve Algoritmalar Kursu

## Insertion Sort Projesi

1-) [22, 27, 16, 2, 18, 6] dizisinin Insertion Sort'a göre adımları;

- [**2**, 27, 16, **22**, 18, 6] : Dizinin başındaki 22 sayısı ile dizideki en küçük sayı olan 2 yer değiştirdi.

- [2, **6**, 16, 22, 18, **27**] : Daha sonra 27 sayısıyla başlayıp diğer sayıları onunla kıyasladık, 6 sayısı dizideki en küçük sayı olduğundan 27 sayısı ile yer değiştirdi.

- [2, 6, **16**, 22, 18, 27] : Daha sonra 16 sayısıyla başlayıp diğer sayıları onunla kıyasladık, 16 sayısı dizideki en küçük sayı olduğundan herhangi bir sayı ile yer değiştirmedi.

- [2, 6, 16, **18**, **22**, 27] : Daha sonra 22 sayısıyla başlayıp diğer sayıları onunla kıyasladık, 18 sayısı dizideki en küçük sayı olduğundan 22 sayısı ile yer değiştirdi.

- [2, 6, 16, 18, 22, 27] : Artık dizimiz sıralı hale geldiğinden sorting işlemi burada son buldu.

2-) Big O gösterimi : O(n^2)

3-) Time Complexity;

- Average Case: Dizinin normal dağılımı.

- Worst Case: Dizinin sıralı ama ters olması.

- Best Case: Dizinin sıralı olması.

4-) Dizi sıralandıktan sonra 18 sayısı dizinin ortalarına denk geleceği için Average Case kapsamına girer.

---

[7, 3, 5, 8, 2, 9, 4, 15, 6] dizisinin Insertion Sort'a göre ilk 4 adımı;

- [**2**, 3, 5, 8, **7**, 9, 4, 15, 6] : Dizinin başındaki 7 sayısı ile dizideki en küçük sayı olan 2 yer değiştirdi.

- [2, **3**, 5, 8, 7, 9, 4, 15, 6] : Daha sonra 3 sayısıyla başlayıp diğer sayıları onunla kıyasladık, 3 sayısı dizideki en küçük sayı olduğundan herhangi bir sayı ile yer değiştirmedi.

- [2, 3, **4**, 8, 7, 9, **5**, 15, 6] : Daha sonra 5 sayısıyla başlayıp diğer sayıları onunla kıyasladık, 4 sayısı dizideki en küçük sayı olduğundan 5 sayısı ile yer değiştirdi.

- [2, 3, 4, **5**, 7, 9, **8**, 15, 6] : Daha sonra 8 sayısıyla başlayıp diğer sayıları onunla kıyasladık, 5 sayısı dizideki en küçük sayı olduğundan 8 sayısı ile yer değiştirdi.
