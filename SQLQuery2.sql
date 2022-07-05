--Select
Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers

Select * from Customers where City = 'London'

--case insesitive
sELecT * from Products where CategoryID = 1 or CategoryID = 3

sELecT * from Products where CategoryID = 1 and UnitPrice >= 10

--önce soldaki(CategoryId) sonra onun içindekilerde sıralama olur(productName)
select * from Products order by CategoryID,ProductName

select * from Products where CategoryID=1 order by UnitPrice desc

select COUNT(*) from Products

select count(*) Adet from Products where CategoryID =2

--group by sadece bulunduğun tablodan alabilir
--select * from Products group by CategoryID bu hatalı olacaktır

select CategoryID from Products group by CategoryID

--virgül bir öncekine bağlıdır yani onun üzerinde işlem olur
select CategoryID,COUNT(*) KacTane from Products group by CategoryID

select CategoryID,COUNT(*) KacTane from Products group by CategoryID having COUNT(*) < 10

---having keywordu kümülatife yani ilk baştaki count operasyonuna
select CategoryID,COUNT(*) KacTane from Products where UnitPrice > 20 group by CategoryID having COUNT(*) < 10


select * from Products inner join Categories
on Products.CategoryID = Categories.CategoryID

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID

--DTO(Data Transformation Object) mantığıydı bu yukarıdaki yani elimizdekileri oluşturduğumuz yeni bir
--tabloda(classta) istediğimiz değişkenleri verip onlarla iş yapıyoruz

--inner join sadece iki tabloda da olanları(eşleşenleri) getirir
select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice > 10

--boşluk sql'de sıkıntı olduğundan köşeli paranteze alırız
--order details tablosu boşluklu olduğundan
select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID

--bu örnekteki left solda yani product tablosunda olup sağda yani 
--order detailste olmayanı getir. Mesela bu örnekte satışın yapılamadığı 
--ürünler listelendi
select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID

--bu arada left de tamamını getirir ama olmayanlar da vardır. işte onlar
--listenin en altında olurlar
select * from Customers c left join Orders o 
on c.CustomerID = o.CustomerID

--bu sorgu ise solda olup sağda olmayanları ayıklayıp çekip çıkarır
--is null ise diğer tarafta karşılığı olmayan yani orderi olmayanlar
--null geçerler. Mesela bu örnek tam bir kampanya yapmalık. sisteme gir
--ama sipariş verme. ilk siparişin ücretsiz olsun. :)
select * from Customers c left join Orders o 
on c.CustomerID = o.CustomerID
where o.CustomerID is null

--right join sağda olup solda olmayanları getirir

select * from Products p inner join [Order Details] od 
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID

