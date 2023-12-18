## Singleton/ Одиночка

Шаблон проектирования "Одиночка" (Singleton) относится к категории
порождающих шаблонов и используется для обеспечения того, чтобы у класса был
только один экземпляр, и предоставляет глобальную точку доступа к этому
экземпляру.

## Prototype/ Прототип
Паттерн "Прототип" (Prototype) – это шаблон проектирования, который позволяет
создавать новые объекты путем клонирования существующих объектов, избегая
необходимости создания объектов с нуля.

## Factory method/ Фабричный метод
Паттерн "Фабричный метод" (Factory Method) – это шаблон проектирования,
который определяет интерфейс для создания объектов, но позволяет подклассам
выбирать классы для создания. Таким образом, он делегирует создание объектов
подклассам.

## Abstract factory/ Абстрактная фабрика
Абстрактная фабрика (Abstract Factory) – это шаблон проектирования, который
предоставляет интерфейс для создания семейств взаимосвязанных объектов, не указывая их конкретных классов.

## Builder/ Строитель
Паттерн Строитель позволяет создавать сложные объекты пошагово. Он позволяет
разделить процесс создания объекта от его представления, что позволяет
создавать разные представления одного и того же объекта.

## Adapter/ Адаптер
Шаблон "Адаптер" (Adapter) – это структурный шаблон проектирования, который
позволяет объектам с несовместимыми интерфейсами работать вместе. Адаптер
предоставляет промежуточный интерфейс, который преобразует интерфейс одного
класса в интерфейс, ожидаемый другим классом.

## Bridge/ Мост
Шаблон позволяет отделить абстракцию от реализации, чтобы они могли
изменяться независимо друг от друга. Этот шаблон особенно полезен, когда у вас
есть несколько способов вариантов реализации для какой-либо абстракции, и вы
хотите, чтобы они могли меняться независимо друг от друга.

## Composite/ Компоновщик
Позволяет создавать иерархии объектов в виде древовидных структур, где как
отдельные объекты, так и их композиты (группы объектов) могут обрабатываться
одинаково. Этот шаблон позволяет клиентам единообразно обращаться к
отдельным объектам и составным структурам.

## Decorator/ Декоратор
В повседневной работе шаблон часто называют “обертка”.
Шаблон позволяет добавлять новую функциональность объектам, не изменяя их
структуру. Декоратор предоставляет гибкую альтернативу наследованию для
расширения функциональности классов

## Facade/ Фасад
Фасад предоставляет унифицированный интерфейс для группы интерфейсов в
подсистеме. Фасад упрощает взаимодействие клиента с комплексной системой,
предоставляя более удобный и понятный интерфейс.

## Flyweight/ Приспособленец
Шаблон позволяет эффективно разделить объекты на общие и индивидуальные
части. Приспособленцы разделяются между несколькими объектами для экономии
памяти и ресурсов. Зачастую приспособленцы применяются вместе с шаблоном
фабрики, и тогда они наиболее эффективны.

## Proxy/ Прокси
Шаблон позволяет создавать объект, который выступает в роли заменителя другого
объекта. Прокси контролирует доступ к оригинальному объекту, позволяя
выполнять дополнительные действия до или после доступа к нему.

## Chain of responsibility/ Цепочка ответственности
Шаблон позволяет создать цепочку объектов, способных обрабатывать запросы
последовательно. Каждый объект в цепочке может решить, может ли он обработать
запрос, и либо обработать его, либо передать дальше по цепочке.

## Command/ Команда
Шаблон инкапсулирует запрос в виде объекта, позволяя параметризовать клиентов
с разными запросами, ставить запросы в очередь, а также поддерживать отмену
операций.

## Interpreter/ Интерпретатор
Шаблон используется для интерпретации и оценки языковых грамматик или
выражений. Он позволяет создавать язык, который позволяет интерпретировать
заданные выражения и выполнять соответствующие действия.

## Iterator/ Итератор
Шаблон предоставляет способ последовательного доступа к элементам коллекции
без раскрытия деталей его внутренней реализации. Этот шаблон позволяет
клиентам обходить элементы коллекции, независимо от того, какая структура
используется для хранения данных. В C# этот шаблон реализуется с помощью интерфейсов IEnumerable и IEnumerator и
активно используется в коде LINQ и циклах foreach. Строго говоря, шаблон
итератора описывает только то, что есть в интерфейсе IEnumerator

## Mediator/ Медиатор
Шаблон обеспечивает централизованную связь между различными компонентами
(коллегами) без необходимости прямого взаимодействия между ними. Медиатор
45
управляет коммуникацией между компонентами, снижая их зависимость друг от
друга.

## Memento/ Хранитель
Шаблон позволяет сохранять и восстанавливать внутреннее состояние объекта без
раскрытия деталей его реализации. Этот шаблон позволяет создавать "снимки"
состояния объекта, которые могут быть восстановлены позже.

## Observer/ Наблюдатель
Шаблон позволяет объектам подписываться на изменения состояния других
объектов и автоматически получать уведомления о таких изменениях. Этот шаблон
обеспечивает связь между объектами, при этом один объект (называемый
"субъектом") уведомляет своих наблюдателей о своих изменениях.

## State/ Состояние
Шаблон позволяет объектам менять свое поведение в зависимости от внутреннего
состояния. Шаблон позволяет создавать классы для каждого состояния объекта и
делегировать выполнение операций в зависимости от текущего состояния.


## Strategy/ Стратегия
Шаблон позволяет определить семейство алгоритмов, инкапсулировать их в
отдельные классы и делать их взаимозаменяемыми. Это позволяет изменять
алгоритмы независимо от клиентов, которые используют эти алгоритмы.


## Template method/ Шаблонный метод
Шаблон определяет скелет алгоритма в базовом классе и позволяет подклассам
переопределять определенные шаги этого алгоритма без изменения его структуры.
Таким образом, он обеспечивает общую структуру алгоритма, но делегирует
конкретную реализацию дочерним классам.

## Visitor/ Посетитель
Шаблон позволяет добавлять новые операции к объектам, не изменяя их классы. Он
позволяет вынести операции из классов объектов в отдельные классы (посетители),
тем самым разделяя сущности объекта и операции над ним