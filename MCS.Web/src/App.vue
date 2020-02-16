<template>
  <div id="app">
    <Menu/>
    <router-view></router-view>
  </div>
</template>

<script>
const Menu = () => import('./components/Menu.vue')

export default {
  name: 'App',
  components: {
    FileList,
    Menu
  }
}
</script>

<style>
</style>
