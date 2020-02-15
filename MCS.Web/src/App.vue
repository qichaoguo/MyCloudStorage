<template>
  <div id="app">
    <Menu/>
    <FileList/>
  </div>
</template>

<script>
const FileList = () => import('./components/FileList.vue')
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
