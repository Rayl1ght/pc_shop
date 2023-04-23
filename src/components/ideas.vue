<template>
    <div class="ideas">
        <HeroInformation
          title="About us"
          description="We have been on the market since 2000, so you can trust us."
          colorTitle="#fff"
          colorDescription="#fff"
          background="#2A254B"
          colorLink="#fff"/>
        <img src="/img/pc-table.jpg" alt="pc">
    </div>
</template>

<script setup>
    import HeroInformation from './HeroInformation.vue'
</script>

<style lang="scss" scoped>
    .ideas {
        padding: 0 80px;
        margin-bottom: 60px;
        display: grid;
        grid-template-columns: repeat(2, 1fr);
        column-gap: 16px;
    }
</style>