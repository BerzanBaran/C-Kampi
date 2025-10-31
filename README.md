# Database CRUD Operations Project

A C# console application that demonstrates basic CRUD (Create, Read, Update, Delete) operations using ADO.NET and SQL Server Express.

## Project Description

This project is a simple database management system that allows users to perform the following operations:
- Add new products and categories
- List existing products
- Update product information
- Delete products from the database

## Technologies Used

- C# 7.3
- .NET Framework 4.7.2
- ADO.NET
- SQL Server Express
- Visual Studio

## Prerequisites

- Microsoft SQL Server Express installed
- Visual Studio (2019 or later recommended)
- .NET Framework 4.7.2 or higher

## Database Configuration

The application connects to a SQL Server Express database with the following configuration:
- Server: `localhost\SQLEXPRESS`
- Database: `EgitimKampiDb`
- Authentication: Windows Authentication (Integrated Security)

## Database Tables

The project uses the following tables:
- `TblProduct`: Stores product information (ProductID, ProductName, ProductPrice, ProductStatus)
- `TblCategory`: Stores category information (CategoryID, CategoryName)

## Features

1. **Product Management**
   - Add new products with name and price
   - Update existing product information
   - Delete products by ID
   - List all products

2. **Category Management**
   - Add new categories
   - View categories

## Usage

1. Run the application
2. Choose from the available operations:
   - Add new products/categories
   - List existing products
   - Update product information
   - Delete products

## Security

- Uses parameterized queries to prevent SQL injection
- Implements integrated Windows authentication for database connections

## Contributing

1. Fork the repository
2. Create your feature branch
3. Commit your changes
4. Push to the branch
5. Create a new Pull Request

## License

This project is available under the MIT License.

## Author
Name:BerzanBaran
GitHub account: https://github.com/BerzanBaran


# Veritabanı CRUD İşlemleri Projesi

ADO.NET ve SQL Server Express kullanarak temel CRUD (Oluşturma, Okuma, Güncelleme, Silme) işlemlerini gösteren bir C# konsol uygulaması.

## Proje Açıklaması

Bu proje, kullanıcıların aşağıdaki işlemleri gerçekleştirmesine olanak tanıyan basit bir veritabanı yönetim sistemidir:
- Yeni ürün ve kategori ekleme
- Mevcut ürünleri listeleme
- Ürün bilgilerini güncelleme
- Veritabanından ürün silme

## Kullanılan Teknolojiler

- C# 7.3
- .NET Framework 4.7.2
- ADO.NET
- SQL Server Express
- Visual Studio

## Ön Koşullar

- Microsoft SQL Server Express yüklü
- Visual Studio (2019 veya üzeri önerilir)
- .NET Framework 4.7.2 veya üzeri

## Veritabanı Yapılandırması

Uygulama, aşağıdaki yapılandırmayla bir SQL Server Express veritabanına bağlanır:
- Sunucu: `localhost\SQLEXPRESS`
- Veritabanı: `EgitimKampiDb`
- Kimlik Doğrulama: Windows Kimlik Doğrulaması (Tümleşik Güvenlik)

## Veritabanı Tabloları

Proje aşağıdaki tabloları kullanır:
- `TblProduct`: Ürün bilgilerini (ProductID, ProductName, ProductPrice, ProductStatus)
- `TblCategory`: Kategori bilgilerini (CategoryID, CategoryName) depolar

## Özellikler

1. **Ürün Yönetimi**
- Ad ve fiyatla yeni ürünler ekle
- Mevcut ürün bilgilerini güncelle
- Ürünleri kimliğe göre sil
- Tüm ürünleri listele

2. **Kategori Yönetimi**
- Yeni kategoriler ekle
- Kategorileri görüntüle

## Kullanım

1. Uygulamayı çalıştır
2. Mevcut işlemlerden birini seç:
- Yeni ürünler/kategoriler ekle
- Mevcut ürünleri listele
- Ürün bilgilerini güncelle
- Ürünleri sil

## Güvenlik

- SQL enjeksiyonunu önlemek için parametreli sorgular kullanır
- Veritabanı bağlantıları için entegre Windows kimlik doğrulaması uygular

## Katkıda Bulunma

1. Depoyu çatallandır
2. Özellik dalını oluştur
3. Değişikliklerini kaydet
4. Dallara gönder
5. Yeni bir Çekme İsteği oluştur

## Lisans

Bu proje MIT Lisansı kapsamındadır.

## Yazar

[Adınız]
BerzanBaran
github hesabı : https://github.com/BerzanBaran
