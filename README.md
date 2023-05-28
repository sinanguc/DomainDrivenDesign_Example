# **DOMAIN DRIVEN DESIGN**

Sürekli değişen iş yapış kurallarının bile bir ahenk ve düzen içerisinde, yazılım projenize başarılı ve derinlemesine uygulanmasını sağlamak amacı ile "Eric Evans" tarafından ortaya atılmış bir yazılım geliştirme yaklaşımıdır.

Bu yaklaşımla birlikte yazılım geliştirme aşamasında veya hayatta geçirilen projelerde sürekliliği ve sürekli yaşanan temel problemlere kalıcı çözümler getirilebilir.

Terminoloji:

1. Ubiquitous Language
2. Bounded Context - Context Mapping
3. Entity & Value Object, Aggregate Root
4. Services - Repository - Infrastructure
5. Layered Architecture
6. Refactoring, Clean & Readable Code

**UBIQUITOUS LANGUAGE**

Yazılımı geliştiren ekip ile ürün uzmanları arasında, ortak bir dil/iletişim olmalıdır.

- Her şeyin karşılığı olması gereklidir. Ürün ile ilgili her şeyin yazılım tarafında karşılığı olmalıdır.)
- Ayrıntılar gündemde olmalıdır. Anlaşılmayan hiçbir noktanın olmaması gereklidir.
- Kullanılan dil iyileştirilmelidir. Yazılımcı ve ürün uzmanı arasında iletişim çok iyi olmalıdır.
- Örnekler somut olmalıdır. Gerekirse canlı örnekler verilmelidir.
- Amacı anlatmalıdır. Ortaya çıkarılan kararlar ve sonuçlar, belirlenen amaçlara hizmet etmelidir.

**BOUNDED CONTEXT - CONTEXT MAPPING**

DDD tasarımında en merkezdeki prensiptir. Birbirinden ayrılmış, çerçeve ve sınırları belirlenmiş yapıdır.

- Bir domain birden fazla subdomain içerebilir. Sipariş, Müşteri, Kullanıcı, Ürün, Stok vb.
- Kendi içlerinde tutarlı olmalı ve bütünlük sağlamalıdır. Stok ile ilgili bütün detaylar bounded context içerisinde olmalı ve kendi içerisinde tutarlı olmalıdır.
- Domain specific language ile ortak kullanılan dil bounded context içerisine de aktarılmalıdır. Bounded context, kullanılan ortak dili benimsemelidir.
- Bounded Context'ler birbirleri ile iletişim kurabilir olmalıdır. Stok ve Sipariş iletişim kuracaksa, bunlar belirli kurallar çerçevesinde olmalıdır. Amaç iletişim kurulurken belirli kurallar belirlemek, subdomainlerin birbirine olan bağımlılıklarını azaltmaktır.
- Context Mapping, Bounded Context'lerin birbirleri ile olan kesişim noktaları ve iletişim mimarisidir. Sipariş ve Müşteri bounded contexti hangi alanları birbirleri ile bağlı veya ayrı olacak bunu belirler. Örn; Müşteri numarası bilgisinin Sipariş Context'inde işlevi varken, sipariş numarası bilgisinin Müşteri Context'inde işlevi yoktur.

**ENTITY & VALUE OBJECT, AGGREGATE ROOT**

Domainimizi modelleme kısmındaki en sık kullanılan kalıplardır.

- **Entity** , kimliğe sahip nesnelerdir. Sipariş bir entity'dir. Çünkü id'si, yani kimliği var. Veri tabanında kayıt oluşturulurken, kayıt işlemi tamamlandığında Sipariş kaydına ilişkin bir kimlik kaydı oluşur. - Base Entity(id)
- **Value Object** , kimliğe sahip olması gerekmeyen nesnelerdir. DTO nesneleri buna örnek olabilir. Entity nesnesi içinde yer alan FullName alanı da örnek olabilir. Bu alan veri tabanında bir kimliğe sahip değildir. Fakat veri tabanında yer alan isim ve soyisim kayıtlarını birleştirip, sanki kimliğe sahipmiş gibi davranır.
- **Aggregate Root** ,Transaction bütünlüğü, ilişkili objeler ve iş kurallarını ifade eder. İçerisinde birbirleri ile sıkı sıkıya bağlı, birlikte işlem yapması gereken nesneler barındırır. E-Ticaret sitelerinde sipariş detaylarına giriş yapıldığında sipariş listesi ile birlikte, siparişe ait ürünlerin listesi de yüklenir. Siparişle birlikte gelen sipariş edilen ürünlerin tek bir servis üzerinden bütünlük sağlanarak gelmesi gerekmektedir. Başka bir örnek vermek gerekirse, sipariş verirken satın alma limiti, stok kontrolü gibi validasyonlarında yapılmasını kolaylaştırır.

**SERVICES - REPOSITORY**

İş kurallarının işletilmesi ve çıktıları yönetmek için kullanılan bölümlerdir.

- **Services** , iş kuralları ve validasyon işlemleri için kullanılır.
- **Repository** , Bazı kurallarla birlikte Aggregate ile veri tabanı arasındaki iletişim için kullanılır.

**LAYERED ARCHITECTURE**

DDD için dört katmanlı (Onion Architecture) mimari en temel kavramdır.

- Domain Layer
- Application Layer
- Infrastructure Layer
- Presentation Layer

**REFACTORING, CLEAN & READABLE CODE**

Geliştirme yapılırken kullanılan metotlara girildiğinde, değişmesi gereken yerlere müdahale etmeyi ve iyileştirmeyi gerektirir. Burada temiz, okunabilir ve performanslı kod yazımı sağlanması, yazılan kodun gelişime açık olması sağlanmalıdır.
