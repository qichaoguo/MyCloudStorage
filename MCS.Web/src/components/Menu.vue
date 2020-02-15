<template>
  <div>
    <Menu mode="horizontal" :theme="theme1" active-name="1">
      <MenuItem name="1">
        <Icon type="ios-paper" />文件下载
      </MenuItem>
      <MenuItem name="2">
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
  }
};
</script>