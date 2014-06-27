require 'test_helper'

class HorarioAlarmasControllerTest < ActionController::TestCase
  setup do
    @horario_alarma = horario_alarmas(:one)
  end

  test "should get index" do
    get :index
    assert_response :success
    assert_not_nil assigns(:horario_alarmas)
  end

  test "should get new" do
    get :new
    assert_response :success
  end

  test "should create horario_alarma" do
    assert_difference('HorarioAlarma.count') do
      post :create, horario_alarma: { hora_fin: @horario_alarma.hora_fin, hora_inicio: @horario_alarma.hora_inicio, motivo: @horario_alarma.motivo }
    end

    assert_redirected_to horario_alarma_path(assigns(:horario_alarma))
  end

  test "should show horario_alarma" do
    get :show, id: @horario_alarma
    assert_response :success
  end

  test "should get edit" do
    get :edit, id: @horario_alarma
    assert_response :success
  end

  test "should update horario_alarma" do
    patch :update, id: @horario_alarma, horario_alarma: { hora_fin: @horario_alarma.hora_fin, hora_inicio: @horario_alarma.hora_inicio, motivo: @horario_alarma.motivo }
    assert_redirected_to horario_alarma_path(assigns(:horario_alarma))
  end

  test "should destroy horario_alarma" do
    assert_difference('HorarioAlarma.count', -1) do
      delete :destroy, id: @horario_alarma
    end

    assert_redirected_to horario_alarmas_path
  end
end
