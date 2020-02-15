<template>
  <div id="app">
    <FileList/>
  </div>
</template>

<script>
const FileList = () => import('./components/FileList.vue')

export default {
  name: 'App',
  components: {
    FileList
  }
}
</script>

<style>
</style>
