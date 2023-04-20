<template>
    <div class="about-brand">
        <h3 class="about-brand__title">About us</h3>
        <div class="about-brand-elements">
            <div 
                class="about-brand-element"
                v-for="(element, i) of aboutBrands"
                :key="i">
                <img 
                    :src="element.img"
                    :alt="element.title"
                     class="about-brand-element__img">
                <h4 class="about-brand-element__title">{{element.title}}</h4>
                <span class="about-brand-element__description">{{element.description}}</span>
            </div>
        </div>
    </div>
</template>

<script setup>
    import {ref} from 'vue'

    const aboutBrands = [
        {
            img: '/svg/about-brand-1.svg',
            title: 'Large assortment',
            description: 'We have products for computers for every taste',
        },
        {
            img: '/svg/about-brand-2.svg',
            title: 'Low prices',
            description: 'Prices are better than those of competitors',
        },
        {
            img: '/svg/about-brand-3.svg',
            title: 'Client orientation',
            description: 'We will help you choose the right product',
        },
        {
            img: '/svg/about-brand-4.svg',
            title: 'Quality Guarantor',
            description: 'We guarantee that all products are perfect and brand new',
        },
    ]
</script>

<style lang="scss" scoped>
    .about-brand {
        padding: 80px 80px 130px 80px;
        &__title {
            text-align: center;
            font-size: 24px;
            color: #2A254B;
            margin: 0 0 84px 0;
        }

        &-elements {
            display: grid;
            grid-template-columns: repeat(4, 210px);
            justify-content: space-between;
        }

        &-element {
            color: #2A254B;

            &-img {

                display: block;
                margin-bottom: 12px;
            }

            &-title {
                margin: 0 0 12px 0;
                font-size: 20px;
            }

            &-description {
                font-size: 16px;
                line-height: 1.5;
            }
        }
    }    
</style>