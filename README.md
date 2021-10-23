# Design Patterns

- [Null Object Pattern](#null-object-pattern)
- [Special Case Pattern](#special-case-pattern)
- [Specification Pattern](#specification-pattern)

## &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <a name="null-object-pattern">Null Object Pattern</a>

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Null nesneler nedeniyle programlarda meydana gelen hataların önüne geçmek ve null kontrolleri ile artan kod karmaşasını önlemek amacıyla null object pattern ortaya çıkmıştır. Aşağıdaki UML diagramında bu pattern'ın yapısı gösterilmiştir. Strategy pattern ile oldukça benzer bir yapısı vardır.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Kod üzerindeki örneğimizde ise, bir öğrenci nesnesi oluşturuluyor ve öğrenci detayları kullanıcıya gösterilmek isteniyor. Kullanıcının verisini veritabanından çektiğimizi düşünürsek null geldiği durumda, null exception almak yerine kullanıcının bilgisi boş verilmiştir.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Böylece null kontrollerini kaldırarak kodumuzu daha sade hale getirmiş ve null exception hatasının da önüne gelmiş olduk. Bu pattern her zaman uygulanmaya uygun olmasa da güzel kullanımlar oluşturulabilir.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Ancak unutulmamalıdır ki, yazılımcılar null objesi dönmek yerine bu abstract yapıya doğrudan null dönebilirler. Bu konu da null object pattern'ın dikkat edilmesi gereken noktasıdır.

![image](https://user-images.githubusercontent.com/16361055/127773141-c75882ea-368e-496d-bb46-0d9d8890587f.png)


## &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <a name="special-case-pattern">Special Case Pattern</a>

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Null object pattern'ın farklı bir çeşidi olan special case pattern, null object pattern'dan farklı olarak belirli bir durum için farklılık gösteren nesne bilgileri dönebilmektedir. Yapı olarak aynı şekilde strategy pattern'ı uygulamaktadır. 

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Kod üzerinde gösterilen örnekte bir kullanıcı bilgisinin alınması örneklendirilmiştir. Kullanıcı bilgisinin başarılı bir şekilde alınamayarak null gelmesi sonucu kullanıcı bulunamadı bilgisini dönecek sınıf verilmiştir.

![image](https://user-images.githubusercontent.com/16361055/127924193-7195240b-02b8-48c2-a81b-6113a13b3036.png)


## &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <a name="specification-pattern">Specification Pattern</a>

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Uygulama içerisindeki kontrollerin düzenli olması, bağımlılıkların azaltılması ve gerektiğinde "and, or vb." gibi ifadelerle kombine edilebilmesi nedeniyle kullanılan kullanışlı bir tasarım desenidir. Ayrıca linq sorguları içerisine kolayca entegrasyonu sayesinde, hem entityframework ile uyumlu çalışmaktadır, hem de uygulama içerisindeki filtrelemelerde kolayca kullanılabilmektedir.

![image](https://user-images.githubusercontent.com/16361055/138568478-5251036d-a279-4823-905c-850c48f5cad3.png)
