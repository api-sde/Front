import Vue from 'vue'
import Router from 'vue-router'
import store from './store'
import Dashboard from './components/Dashboard.vue'
import Login from './components/Login.vue'
import Auth from '@okta/okta-vue'

Vue.use(Router)
Vue.use(Auth, {
    issuer: 'https://dev-240670.oktapreview.com/oauth2/default',
    client_id: '0oadn6xroz1VfV6fv0h7',
    redirect_uri: 'http://localhost:51564/implicit/callback',
    scope: 'openid profile email'
})

function requireAuth(to, from, next) {
    if (!store.state.loggedIn) {
        next({
            path: '/login',
            query: { redirect: to.path }
        })
    } else {
        next()
    }
}

export default new Router({
    mode: 'history',
    base: __dirname,
    routes: [
        { path: '/', component: Dashboard, beforeEnter: requireAuth },
        { path: '/login', component: Login },
        { path: '/logout',
            async beforeEnter(to, from, next) {
                await store.dispatch('logout')
            }
        },
        { path: '/implicit/callback', component: Auth.handleCallback() }
    ]
})
