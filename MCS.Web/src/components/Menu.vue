<template>
  <div>
    <Menu mode="horizontal" :theme="theme1" active-name="1" @on-select="select">
      <MenuItem name="download">
        <Icon type="ios-paper" />文件下载
      </MenuItem>
      <MenuItem name="upload">
        <Icon type="ios-people" />文件上传
      </MenuItem>
    </Menu>
  </div>
</template>
<script>
export default {
  data() {
    return {
      theme1: "light"
    };
  },
  methods: {
    select(name) {
      this.$router.replace('/'+name);
    }
  }
};
</script>