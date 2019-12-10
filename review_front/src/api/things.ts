const things = {
    configs: [
        {
            id: 1,
            name: 'Macdonalds',
            urlImage: 'https://cater.by/wp-content/uploads/2017/06/Makdonalds-kopiya.jpg',
            rate: 3,
            description: 'Макдо́налдс — американская корпорация, работающая в сфере общественного питания, до 2010 года крупнейшая в мире сеть ресторанов быстрого питания, работающая по системе франчайзинга. На конец 2018 года под торговой маркой McDonald’s работало 37 855 ресторанов, из них 35 085 на правах франчайзинга. Корпорация входит в список крупнейших компаний США Fortune 500 (в 2019 году 149-е место). Штаб-квартира компании расположена в пригороде Чикаго Оук-Бруке.',
            comments: [{
                userName: 'Arial S.',
                text: "I love this place. It's a small restaurant with extremely friendly people that run it. I was not familiar with Nepalese food before coming here, but it reminds me of Indian food, maybe lighter. I come here quite often (I live in the neighborhood) and every dish I've had has been delicious."
            },{
                userName: 'Jhia L.',
                text: "First time visiting and can't wait to go again. Everyone who worked here was a nice mix of helpful/attentive and gave us space to sit/eat/talk without feeling rushed. They answered our questions about the food and helped us from ordering too much and the food was great! I can't stop thinking about the fresh garlic naan and the appetizer that was chickpea fried veggies."
            }]
        },
        {
            id: 2,
            name: 'McDonner',
            urlImage: 'https://memsamazingideas.files.wordpress.com/2010/03/300_962571.jpg?w=584',
            rate: 4,
            description: 'Ресторан быстрого питания MC Doner в Гродно - немецкая сеть Döner-Kebab. Карта проезда, телефоны и режим работы на страницах TAM.BY.',
            comments: [{
                userName: 'John',
                text: 'I was looking for a restaurant I found this cool place they had really great customer service their food was amazing highly recommended.'
            },{
                userName: 'Keri S.',
                text: "Great dinner experience ever I had with my family and friends here. It was good place to dine with many people at one place. The meal was very tasty and delicious. No doubt, it's a great choice to have Asian food taste. Highly Recommendations!!!"
            }]
        },
        {
            id: 3,
            name: 'Greenwich',
            urlImage: 'http://eda.s13.ru/content/relax-logo/isesyi-gJT.jpg',
            rate: 4,
            description: "Greenwich – это ресторан-паб в английском стиле, который расположился на главной улице города. Интерьер заведения выполнен в коричневых и зеленых тонах. Шотландская клетка на потолке, граффити на стенах, кожаные диваны и сцена в виде старого вагончика.",
            comments: [{
                userName: 'Вячеслав',
                text: 'Были 22.10.2019г. Впечатление супер !!! Искали недостатки, а они не нашлись. Блюда заказанные все на отлично.Рекомендую всем. Незря в будний день все места заняты.С женой вышло 100р.,остались довольны.Хотим туда вернуться...'
            },{
                userName: 'Екатерина',
                text: "Я первый раз на выходных с друзьями попала в это заведение. Собиралась много раз туда сходить, но там все время бронь за 2 недели вперед и очень странно, потому что заведение меня полностью разочаровало! Интерьер никакой! Меню очень слабое и почти нечего выбрать, особенно вегетарианцам или людям, которые не едят мясо или едят рыбу. Ведь у нас сейчас XXI век и с каждым днем становится все больше лю..."
            }]
        },
        {
            id: 4,
            name: 'Telenok',
            urlImage: 'https://telenok.by/d/img-0527.jpg',
            rate: 5,
            description: "Greenwich – это ресторан-паб в английском стиле, который расположился на главной улице города. Интерьер заведения выполнен в коричневых и зеленых тонах. Шотландская клетка на потолке, граффити на стенах, кожаные диваны и сцена в виде старого вагончика.",
            comments: [{
                userName: 'Вячеслав',
                text: 'Были 22.10.2019г. Впечатление супер !!! Искали недостатки, а они не нашлись. Блюда заказанные все на отлично.Рекомендую всем. Незря в будний день все места заняты.С женой вышло 100р.,остались довольны.Хотим туда вернуться...'
            },{
                userName: 'Екатерина',
                text: "Я первый раз на выходных с друзьями попала в это заведение. Собиралась много раз туда сходить, но там все время бронь за 2 недели вперед и очень странно, потому что заведение меня полностью разочаровало! Интерьер никакой! Меню очень слабое и почти нечего выбрать, особенно вегетарианцам или людям, которые не едят мясо или едят рыбу. Ведь у нас сейчас XXI век и с каждым днем становится все больше лю..."
            }]
        },
        {
            id: 5,
            name: 'Cinema',
            urlImage: 'http://eda.s13.ru/content/relax-logo/isesyi-gJT.jpg',
            rate: 4,
            description: "Greenwich – это ресторан-паб в английском стиле, который расположился на главной улице города. Интерьер заведения выполнен в коричневых и зеленых тонах. Шотландская клетка на потолке, граффити на стенах, кожаные диваны и сцена в виде старого вагончика.",
            comments: [{
                userName: 'Вячеслав',
                text: 'Были 22.10.2019г. Впечатление супер !!! Искали недостатки, а они не нашлись. Блюда заказанные все на отлично.Рекомендую всем. Незря в будний день все места заняты.С женой вышло 100р.,остались довольны.Хотим туда вернуться...'
            },{
                userName: 'Екатерина',
                text: "Я первый раз на выходных с друзьями попала в это заведение. Собиралась много раз туда сходить, но там все время бронь за 2 недели вперед и очень странно, потому что заведение меня полностью разочаровало! Интерьер никакой! Меню очень слабое и почти нечего выбрать, особенно вегетарианцам или людям, которые не едят мясо или едят рыбу. Ведь у нас сейчас XXI век и с каждым днем становится все больше лю..."
            }]
        }

    ]
}

export const getThings = () => {
    return things.configs
}

export const getThing = (id: number) => {
    return things.configs.find(x => x.id === id)
}

export const updateThing = (thing: any) => {
    const id = things.configs.findIndex(x => x.id == thing.id)

    if (id) {
        things.configs[id] = thing
    }
}
