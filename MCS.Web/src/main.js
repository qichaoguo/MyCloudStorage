import Vue from 'vue'
import App from './App.vue'
//引入viewUI
import ViewUI from 'view-design'
import 'view-design/dist/styles/iview.css'

Vue.config.productionTip = false

//安装ViewUI
Vue.use(ViewUI)

new Vue({
  render: h => h(App),
}).$mount('#app')
