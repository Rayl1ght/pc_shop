<template>
    <div class="product">
        <a href="#">
            <img :src="img" :alt="title" class="product-image">
        </a>
        <a href="#" class="product-name">{{title}}</a>
        <span class="product-price">${{price}}</span>
    </div>
</template>

<script setup>
    const props = defineProps({
        img: {
            type: String,
            required: true
        },
        title: {
            type: String,
            required: true
        },
        price: {
            type: Number,
            required: true
        }
    })
</script>