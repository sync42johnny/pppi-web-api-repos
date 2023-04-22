**1.** REST API (Representational State Transfer) - це архітектурний стиль взаємодії компонентів в мережі, який використовується для розробки веб-сервісів. Він базується на принципах безстановості, кешування, єдиної інтерфейсної точки, та розділенні клієнта та сервера. REST API дозволяє легко обмінюватися даними між системами, використовуючи стандартні протоколи, такі як HTTP.

**2.** Різниця між REST і RESTful полягає в тому, що REST відноситься до архітектурних принципів, на яких будуються веб-сервіси, тоді як RESTful - це термін, який описує веб-сервіс, який реалізує REST архітектуру. Отже, RESTful API - це веб-API, який дотримується принципів REST.

**3. Основні HTTP методи, які використовують для розробки WebAPI:**
GET: використовується для отримання інформації з сервера.
POST: використовується для створення нових ресурсів на сервері.
PUT: використовується для оновлення існуючих ресурсів на сервері.
DELETE: використовується для видалення ресурсів з сервера.
PATCH: використовується для часткового оновлення ресурсів на сервері.

**4.** Різниця між REST API та JSON API полягає в тому, що REST API - це архітектурний стиль для розробки веб-сервісів, який може використовувати різні формати даних (наприклад, JSON, XML тощо), тоді як JSON API - це специфікація для створення RESTful API, яка використовує JSON як формат даних для обміну даними.

**5.** Розробка REST API базується на декількох основних принципах, відповідність яким допомагає забезпечити ефективність та надійність API.
Основні принципи для розробки REST API:</br>
- 1. Архітектура клієнт-сервер: Клієнт та сервер повинні бути розділені один від одного і не повинні зберігати стану один в іншому. Це дозволяє кожній стороні ефективно виконувати свої функції та спрощує масштабування та розвиток API.</br>
- 2. Використання HTTP методів: REST API використовує HTTP методи, такі як GET, POST, PUT та DELETE, для доступу до ресурсів. Кожен метод має свою власну функцію та використовується залежно від потреб користувача.</br>
- 3. Наявність ідентифікаторів ресурсів: REST API повинен забезпечувати доступ до ресурсів з використанням унікальних ідентифікаторів. Це дозволяє користувачам точно вказувати ресурс, до якого вони звертаються.</br>
- 4. Передача даних у форматі JSON або XML: REST API повинен передавати дані у форматі JSON або XML, що дозволяє забезпечити максимальну сумісність з різними програмними засобами та забезпечує зручність роботи з даними.</br>
- 5. Кешування: REST API повинен дозволяти кешувати результати запитів для зменшення навантаження на сервер та покращення продуктивності API.</br>
- 6. Stateless: REST API повинен бути без стану. Це означає, що кожен запит повинен містити всю необхідну інформацію для його виконання, без використання будь-якої інформації, збереженої на сервері між запитами.</br>
