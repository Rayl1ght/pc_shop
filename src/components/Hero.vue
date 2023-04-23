<template>
    <div class="hero">
        <div class="hero-info">
            <HeroInformation
                title="Cool PC"
                description="900 $"
                link="#"/>
        </div>
    </div>
</template>

<script setup>
    import HeroInformation from './HeroInformation.vue'
</script>

<style lang="scss" scoped>
    .hero {
        background: url('https://digital-discount.ru/wp-content/uploads/d/9/0/d9053a5373e7fb7b2d47f8aca75db348.jpeg');
        height: 704px;
        background: cover;
        display: flex;
        align-items: center;
        justify-content: flex-end;
        padding-right: 80px;

        &-img {
            max-width: 100%;
        }

    }  
</style>