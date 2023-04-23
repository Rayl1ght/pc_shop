<template>
    <div class="products-container">
        <div class="products">
            <Product v-for="product of products"
                     :key="product.id"
                     :img="product.img"
                     :title="product.title"
                     :price="product.price" />
        </div>
        <a href="#" class="products-link">View products</a>
    </div>
</template>

<script setup>
    import { ref } from 'vue'
    import Product from '../components/Product.vue'

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
            title: 'CPU',
            price: 250
        },
        {
            id: 3,
            img: '/img/product3.jpg',
            title: 'RAM',
            price: 250
        },
        {
            id: 4,
            img: '/img/product4.jpg',
            title: 'Power unit',
            price: 250
        }
    ])
</script>

<style lang="scss" scoped>
    .products {
        padding: 0 80px;
        display: flex;
        grid-template-columns: repeat(4, 1fr);
        column-gap: 20px;

        &-container {
            margin-bottom: 56px;
        }

        &-link {
            display: block;
            text-align: center;
            color: #2A254B;
            text-decoration: none;

            &:hover {
                text-decoration: underline
            }
        }
    }
</style>