import OktaAuth from '@okta/okta-auth-js'


const org = 'https://dev-240670-admin.oktapreview.com',
    clientId = '0oadlod3rmJVz5n6M0h7',
    redirectUri = 'http://localhost:51654',
    authorizationServer = 'default'

const oktaAuthClient = new OktaAuth({
    url: org,
    issuer: authorizationServer,
    clientId,
    redirectUri
})

export default {
    client: oktaAuthClient
}
