# The Cashier
Aplikasi ini mencakup fungsi perhitungan yaitu penjumlahan dan perkalian yang digunakan untung menghitung harga barang/jasa yang akan dibeli oleh customer atau pelanggan, aplikasi ini juga dapat mencatat semua transaksi penjumlahan dengan menampilkan data list.

## Scope & Functionalities
- user dapat mengetikan/memasukkan kata(huruf/angka)
- user dapat menyentuh tombol dan dapat memilih sebuah opsi (Barang/ Jasa)
- user dapat menyentuh tombol Tambahkan
- user dapat melihat data list yang telah ditambahkan sebelumnya

## How Does it Works?
Diawali dengan method `MainWindow` pada class MainWindow.xaml.cs, kita mendeklarasikan 

``` csharp
public MainWindow()
        {
            InitializeComponent();
            calculator = new Calculator();
            listBox.ItemsSource = calculator.getListItem();
        }
```


logika perhitungan terdapat pada class `Item.cs`
Cara kerjanya yaitu menjumlahkan semua price dan mengkalikan price dengan quantitynya.
``` csharp
public double getSubtotal()
        {
            subtotal = price * quantity;
            return subtotal;
        }
```


selesai.
