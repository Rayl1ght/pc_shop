<template>
    <div class="hero-info-text">
        <h2 class="hero-info__title">{{title}}</h2>
        <span class="hero-info__description">{{description}}</span>
    </div>
    <a :href="link" class="hero-info-link">BUY</a>
</template>

<script setup>
    const props = defineProps({
        title: {
            type: String,
            required: false
        },
        description: {
            type: String,
            required: false
        },
        link: {
            type: String,
            required: false
        }
    })
</script>

<style lang="scss" scoped>
    .hero {
        &-info {
            background: #fff;
            max-width: 630px;
            padding: 50px 55px;
            height: 444px;
            display: flex;
            flex-direction: column;
            justify-content: space-between;

            &__title {
                font-family: 'Satoshi', sans-serif;
                font-weight: 400;
                line-height: 1.5;
                margin: 0 0 20px;
            }

            &__description {
                color: #5b5676;
                font-size: 18px;
            }

            &-link {
                color: #2A254B;
                text-decoration: none;

                &:hover {
                    text-decoration: underline;
                }
            }
        }
    }
</style>