# [Patika.dev](https://www.patika.dev/tr) İleri Seviye GIT Kursu

## Kurs Notları

Eğer son commitin içeriğini değiştirmek istersek,

```shell
git add . // son değişiklikleri versiyonlanmak üzere ekledik
git commit --amend // ile değişiklikleri commit ettik
```

Eğer son commitin mesajını değiştirmek istersek,

```shell
git commit --amend -m "Yeni mesaj" // ile yeni commit mesajını verdik
```

Sondan x adet commiti loglamak istersek,

```shell
git log -n x // x burada bir sayı olmalı
```

Yapılan bir commiti geri almak istersek,

```shell
git revert commitID // geri almak istediğimiz commitin IDsini verdik

// revert ile commiti geri alırken bizden yeni bir commit içeriği girmemizi ister
```

Commitleri geri almak istiyoruz fakat yeni bir commit oluşmasını istemiyorsak,

```shell
git reset --hard commitID // buradaki commitID hangi commite geri dönmek istiyorsak o commitin IDsi olmalı ve o commite kadar olan aradaki bütün commitleri siler
```

Eğer commitler arasındaki farkları görmek istersek,

```shell
git diff eskiCommitID..yeniCommitID dosyaAdi

// eskiCommitID..yeniCommitID burada iki commitin IDlerini verdik

// dosyaAdi parametresi opsiyoneldir eğer bu parametreyi vermeseydik bütün dosyaları karşılaştıracaktı
```
