import Vue from 'vue'
import VueRouter from 'vue-router'

const Download = () => import('../views/download/Download.vue')
const Upload = () => import('../views/upload/Upload.vue')

Vue.use(VueRouter)

const routes = [
    {
        path:'',
        redirect:'/download'
    },
    {
        path:'/download',
        component:Download
    },
    {
        path:'/upload',
        component:Upload
    }
]


const router = new VueRouter({
    routes,
    mode:'history'
})

export default router