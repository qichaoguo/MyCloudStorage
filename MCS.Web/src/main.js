import Vue from 'vue'
import App from './App.vue'
import router from './router'
//引入viewUI
import ViewUI from 'view-design'
import 'view-design/dist/styles/iview.css'

import axios from 'axios'
import VueAxios from 'vue-axios'

Vue.config.productionTip = false

//安装ViewUI
Vue.use(ViewUI)
Vue.use(VueAxios, axios)

new Vue({
  router,
  render: h => h(App),
}).$mount('#app')
