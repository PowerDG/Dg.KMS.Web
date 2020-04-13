import Vue from 'vue'
import Router from 'vue-router'
import HelloWorld from '@/components/HelloWorld'

import draggabledTree from '@/components/draggabledTree'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/2',
      name: 'HelloWorld',
      component: HelloWorld
    },
    
    {
      path: '/',
      name: 'draggabledTree',
      component: draggabledTree
    }
  ]
})
