# P112-20190919-CS-Project

İdman zalı (Gym) Proqramı

Proqramda aşağıdakı funksionallıqlar olmalıdır:
- Müştəri qeydiyyatı (CRUD)
- Paketlər (CRUD)
- Ödənişlər
- Bar menu (müştəri zalın barından menuda olan istədiyi şeyi ala bilməlidir. su, kokteyl, meyvə və s.)


Application ilk formu olan idarəetmə paneli (dashboard) olmalıdır. Bu formda müştərilərin siyahısı görünməlidir. Həmin siyahıda sadalanan məlumatlar olmalıdır: müştərinin adı, soyadı, seçilmiş olan paket, paketin qiyməti, ödənişin bitmə tarixi 

Əgər dashboard formunda siyahısıda ödənişin vaxtı bitmiş olan müştəri olarsa, o müştərini digərlərindən fərqləndirmək üçün həmin sətrin arxa fon rəngini fərqli etmək lazımdır.

Müştəri bardan hər hansı bir şey almaq istədiyi zaman əgər müştərinin balansında kifayət qədər məbləğ olmasa sifariş yaranmamalıdır.

Application-da modellər aşağıdakı kimi olmalıdır:
- Customer (müştəri)
  - Firstname
  - Lastname
  - Birthday
  - Phone
- Package (paket)
  - Name
  - Price
  - EntryQuantity
- Payment
  - CustomerId
  - PackageId
  - CreatedAt (DateTime)
  - Price
- MenuItem
  - Name
  - Price
- MenuOrder
  - CustomerId
  - MenuItemId
  - Quantity
 
