<template>
    <div class="container">
        <Header />
        <Hero />
        <AboutBrand />
        <Products/>
    </div>
</template>

<script setup>
    import Header from './components/Layout/Header.vue'
    import Hero from './components/Hero.vue'
    import AboutBrand from './components/AboutBrand.vue'
    import Products from './components/Products4Column.vue'

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