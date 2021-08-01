# Design Patterns

- [Null Object Pattern](#null-object-pattern)

## &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <a name="null-object-pattern">Null Object Pattern</a>

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Null nesneler nedeniyle programlarda meydana gelen hataların önüne geçmek ve null kontrolleri ile artan kod karmaşasını önlemek amacıyla null object pattern ortaya çıkmıştır. Aşağıdaki UML diagramında bu pattern'ın yapısı gösterilmiştir. Strategy pattern ile oldukça benzer bir yapısı vardır.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Kod üzerindeki örneğimizde ise, bir öğrenci nesnesi oluşturuluyor ve öğrenci detayları kullanıcıya gösterilmek isteniyor. Kullanıcının verisini veritabanından çektiğimizi düşünürsek null geldiği durumda, null exception almak yerine kullanıcının bulunamadığı bilgisi verilmiştir.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Böylece null kontrollerini kaldırarak kodumuzu daha sade hale getirmiş ve null exception hatasının da önüne gelmiş olduk. Bu pattern her zaman uygulanmaya uygun olmasa da güzel kullanımlar oluşturulabilir.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Ancak unutulmamalıdır ki, yazılımcılar null objesi dönmek yerine bu abstract yapıya doğrudan null dönebilirler. Bu konu da null object pattern'ın dikkat edilmesi gereken noktasıdır.

![image](https://user-images.githubusercontent.com/16361055/127773141-c75882ea-368e-496d-bb46-0d9d8890587f.png)
