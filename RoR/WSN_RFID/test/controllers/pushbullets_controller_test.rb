require 'test_helper'

class PushbulletsControllerTest < ActionController::TestCase
  setup do
    @pushbullet = pushbullets(:one)
  end

  test "should get index" do
    get :index
    assert_response :success
    assert_not_nil assigns(:pushbullets)
  end

  test "should get new" do
    get :new
    assert_response :success
  end

  test "should create pushbullet" do
    assert_difference('Pushbullet.count') do
      post :create, pushbullet: { email: @pushbullet.email, motivo: @pushbullet.motivo, token: @pushbullet.token }
    end

    assert_redirected_to pushbullet_path(assigns(:pushbullet))
  end

  test "should show pushbullet" do
    get :show, id: @pushbullet
    assert_response :success
  end

  test "should get edit" do
    get :edit, id: @pushbullet
    assert_response :success
  end

  test "should update pushbullet" do
    patch :update, id: @pushbullet, pushbullet: { email: @pushbullet.email, motivo: @pushbullet.motivo, token: @pushbullet.token }
    assert_redirected_to pushbullet_path(assigns(:pushbullet))
  end

  test "should destroy pushbullet" do
    assert_difference('Pushbullet.count', -1) do
      delete :destroy, id: @pushbullet
    end

    assert_redirected_to pushbullets_path
  end
end
