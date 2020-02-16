<template>
  <div>
    <List>
      <ListItem v-for="item in items" :key="item.name">
        <ListItemMeta
          :avatar="item.fileType==0?'https://ss1.bdstatic.com/70cFuXSh_Q1YnxGkpoWK1HF6hhy/it/u=2709231154,3146681849&fm=26&gp=0.jpg':'https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1581777619092&di=1fbdb837db675167cee1564d3343a4a3&imgtype=0&src=http%3A%2F%2Fwww.51yuansu.com%2Fpic2%2Fcover%2F00%2F37%2F52%2F58120f5f343d6_610.jpg'"
          :title="item.name"
        />
        <template slot="action" v-if="item.fileType==1">
          <li>
            <a :href="'http://114.115.176.171:5005/myfile/down/'+item.name">下载</a>
          </li>
        </template>
      </ListItem>
    </List>
  </div>
</template>

<script>
export default {
  name: "FileList",
  data() {
    return {
      items: []
    };
  },
  created() {
    this.axios.get('http://114.115.176.171:5005/myfile').then(response => {
      this.items = response.data;
    });
  }
};
</script>

<style scoped>
</style>
