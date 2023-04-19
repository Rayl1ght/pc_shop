<template>
    <div class="hero">
        <div class="hero-info">
            <div class="hero-info-text">
                <h2 class="hero-info__title">Cool PC</h2>
                <span class="hero-info__description">900 $</span>
            </div>
            <a href="#" class="hero-info-link">BUY</a>
        </div>
    </div>
</template>

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