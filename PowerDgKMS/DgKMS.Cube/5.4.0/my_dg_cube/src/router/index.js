import Vue from 'vue'
import Router from 'vue-router'
import HelloWorld from '@/components/HelloWorld'
import ColorTag from '@/components/ColorTag'

import First from '@/views/First'
Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'HelloWorld',
      component: HelloWorld
    },
    {
      path: '/first',
      name: 'first',
      component: First
    },
    {
      path: '/ColorTag',
      name: 'ColorTag',
      component: ColorTag
    }
  ]
})
