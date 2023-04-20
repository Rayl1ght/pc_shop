<template>
    <div class="container">
        <Header />
        <Hero />
        <AboutBrand />
        <Products v-for="product of products"
                  :key="product.id"
                  :img="product.img"
                  :title="product.title"
                  :price="product.price" />
    </div>
</template>

<script setup>
    import {ref} from 'vue'
    import Header from './components/Layout/Header.vue'
    import Hero from './components/Hero.vue'
    import AboutBrand from './components/AboutBrand.vue'
    import Products from './components/Products4Column.vue'

    const products = ref([
        {
            id: 1,
            img: '/img/product1.jpg',
            title: 'Video card',
            price: 250
        },
        {
            id: 2,
            img: '/img/product2.jpg',
            title: 'Video card',
            price: 250
        },
        {
            id: 3,
            img: '/img/product3.jpg',
            title: 'Video card',
            price: 250
        },
        {
            id: 4,
            img: '/img/product4.jpg',
            title: 'Video card',
            price: 250
        }
    ])
</script>



<style lang="scss">
    @import url('https://fonts.cdnfonts.com/css/clash-display');
    @import url('https://fonts.cdnfonts.com/css/satoshi');

    * {
        box-sizing: border-box;
        font-weight: 400;
    }

    body {
        margin: 0;
        padding: 0;
        font-family: 'Clash Display', sans-serif;
        font-size: 16px;
        //  font-family: 'Satoshi', sans-serif;
    }

    img {
        max-width: 100%;
    }

    .container {
        max-width: 1440px;
        margin: auto;
    }
</style>
