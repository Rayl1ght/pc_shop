<template>
    <header class="header">
        <div class="header-top">
            <div class="header-top-search">
                <img src="/svg/header-search.svg " alt="search">
            </div>
            <a href="#" class="header-logo">NicePC</a>
            <div class="header-top-right">
                <div class="header-top-right__cart">
                    <a href="#">
                        <img src="/svg/header-cart.svg " alt="search">
                    </a>
                </div>
                <div class="header-top-right__profile">
                    <a href="#">
                        <img src="/svg/header-profile.svg " alt="search">
                    </a>
                </div>
            </div>
        </div>
        <div class="header-menu">
            <a 
               class="header-menu__link"
               :href="element.path" v-for="(element, i) of menu"
               :key="i">{{element.name}}</a>
        </div>
    </header>
</template>

<script setup>
    import { ref } from 'vue'

    const menu = [
        {
            name: 'accessories',
            path: '/accessories'
        },
        {
            name: 'accessories 2',
            path: '/accessories 2'
        },
        {
            name: 'accessories 3',
            path: '/accessories 3'
        }
    ]
</script>

<style lang="scss" scoped>
    .header {
        height: 132px;
        background: #fff;

        &-top {
            display: grid;
            grid-template-columns: repeat(3, 1fr);
            height: 70px;
            align-items: center;
            border-bottom: 1px solid rgba(0, 0, 0, .1);
            margin: 0 28px;

            &-right {
                display: flex;
                align-items: center;
                justify-content: flex-end;

                &__cart {
                    margin-right: 16px;
                }
            }
        }

        &-logo {
            color: #22202E;
            font-size: 24px;
            text-decoration: none;
            font-family: 'Clash Display', sans-serif;
            text-align: center;

            &:hover {
                text-decoration: underline;
            }
        }

        &-menu {
            height: 62px;
            display: flex;
            justify-content: center;
            align-items: center;

            &__link {
                margin: 0 22px;
                color: #726E8D;
                text-decoration: none;

                &:hover {
                    text-decoration: underline;
                }
            }
        }
    }
</style>