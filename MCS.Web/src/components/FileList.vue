<template>
  <List>
    <ListItem>
      <ListItemMeta
        avatar="https://ss1.bdstatic.com/70cFuXSh_Q1YnxGkpoWK1HF6hhy/it/u=2709231154,3146681849&fm=26&gp=0.jpg"
        title="文件夹"
      />
    </ListItem>
    <ListItem>
      <ListItemMeta
        avatar="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1581777619092&di=1fbdb837db675167cee1564d3343a4a3&imgtype=0&src=http%3A%2F%2Fwww.51yuansu.com%2Fpic2%2Fcover%2F00%2F37%2F52%2F58120f5f343d6_610.jpg"
        title="文件"
      />
      <template slot="action">
        <li>
          <a href="">下载</a>
        </li>
      </template>
    </ListItem>
  </List>
</template>

<script>
export default {
  name: "FileList"
};
</script>

<style scoped>
</style>
